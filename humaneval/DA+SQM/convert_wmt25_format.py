import pandas as pd
import ipdb
import glob
import json


def lp_map(src_lang, tgt_lang):
    mapping = {
        "ces": "cs",
        "ukr": "uk",
        "deu": "de",
        "eng": "en",
        "jpn": "ja",
        "zho": "zh",
    }
    src_lang = mapping[src_lang]
    tgt_lang = mapping[tgt_lang]
    return f"{src_lang}-{tgt_lang}"


def main(domain_mapping, systems, filename):
    domain_mapping = systems[['docid','domain','lp']].drop_duplicates().set_index(['docid','lp'])['domain'].to_dict()

    df = pd.read_csv('WMT23.scores_all.csv', header=None)
    df.columns = ["userid", "systemid", "segmentid", "type", "src_lang", "tgt_lang", "score", "documentid", "isdocument", "starttime", "endtime"]

    df = df[df['type']=="TGT"]
    # we are dropping document scores
    df = df[~df['isdocument']]

    df['lp'] = df.apply(lambda x: lp_map(x['src_lang'], x['tgt_lang']), axis=1)

    del df['type']
    del df['isdocument']
    del df['src_lang']
    del df['tgt_lang']

    df['domain'] = df.apply(lambda x: domain_mapping[(x['documentid'],x['lp'])], axis=1)


    df['doc_id'] = df.apply(lambda x: f"{x['lp']}_#_{x['domain']}_#_{x['documentid']}_#_{x['segmentid']}", axis=1)
    del df['segmentid']

    # normalize system names
    df['systemid'] = df['systemid'].apply(lambda x: x.replace("Human-", "").replace('GTCOM_DLUT', 'GTCOM_Peter').replace('LanguageX', "ZengHuiMT"))
 

    data = []
    for doc_id, group in df.groupby(by='doc_id'):
        texts = systems[systems['doc_id']==doc_id]
        texts = texts[texts['system'].isin(group['systemid'].unique())]
        if len(texts) != len(group['systemid'].unique()):
            print(systems[systems['doc_id']==doc_id]['system'])
            print(group['systemid'].unique())
            ipdb.set_trace()
        assert len(texts) == len(group['systemid'].unique()), "missing some texts"

        src_text = texts['src'].unique()
        if len(src_text) != 1:
            ipdb.set_trace()
        assert len(src_text) == 1, "There are differences in source text"
        src_text = src_text[0]

        # sort group by esa_score so better system is first
        group = group.sort_values(by="score", ascending=False)

        tgt_text = texts[['hyps', 'system']].drop_duplicates().set_index('system').to_dict()['hyps']

        scores = {}
        for systemid, sys_group in group.groupby(by='systemid'):
            human_scores = []

            # sort sys_group by starttime
            sys_group = sys_group.sort_values(by="starttime")

            # if there are duplicates for userid keel the last one

            humans = len(sys_group['userid'].unique())
            if len(sys_group) != humans:
                # annotator changed mind
                sys_group = sys_group.drop_duplicates('userid', keep="last")
            
            for _, row in sys_group.iterrows():
                human_scores.append({
                    "score": float(row['score']),
                    "annotator": row['userid'],
                    "times": [row['starttime'], row['endtime']],
                    "protocol": "DA+SQM"
                })
            scores[systemid] = human_scores

        data.append(
            {
                "scores": scores,
                "src_text": src_text,
                "tgt_text": tgt_text,
                "doc_id": doc_id,
            }
        )
        
    df = pd.DataFrame(data)
    df.to_json(filename, force_ascii=False, lines=True, orient="records")


if __name__ == '__main__':

    sources = {}
    for file in glob.glob("../../txt/sources/*"):
        lp = file.split('.')[-3]
        src = []
        with open(file) as fh:
            for line in fh:
                src.append(line.strip())
        sources[lp] = src
    
    metainfo = {}
    for file in glob.glob("../../txt/metainfo/*"):
        lp = file.split('.')[-3]
        src = []
        with open(file) as fh:
            for line in fh:
                line = line.replace("user_review", "userreview")
                src.append(json.loads(line))


        
        df = pd.DataFrame(src)
        df['sntid'] = -1
        # append 1,2,3,4 as sntid and reset for each docid
        for index, row in df.iterrows():
            if index == 0:
                df.at[index, 'sntid'] = 1
            else:
                if row['docid'] == df.at[index-1, 'docid']:
                    df.at[index, 'sntid'] = df.at[index-1, 'sntid'] + 1
                else:
                    df.at[index, 'sntid'] = 1
        
        metainfo[lp] = df

    systems = {}
    for file in glob.glob("../../txt/system-outputs/*"):
        lp = file.split('.')[-4]
        system = file.split('.')[-2]
        if lp not in systems:
            systems[lp] = {}
        src = []
        with open(file) as fh:
            for line in fh:
                src.append(line.strip())

        df = pd.DataFrame({'src': sources[lp], 'hyps': src})
        df = pd.concat([df, metainfo[lp]], axis=1)
        systems[lp][system] = df

    for file in glob.glob("../../txt/references/*"):
        lp = file.split('.')[-4]
        system = file.split('.')[-2]
        src = []
        with open(file) as fh:
            for line in fh:
                src.append(line.strip())

        df = pd.DataFrame({'src': sources[lp], 'hyps': src})
        df = pd.concat([df, metainfo[lp]], axis=1)
        systems[lp][system] = df

    hyps_mapping = []
    for lp in systems:
        for system in systems[lp]:
            df = systems[lp][system]
            df['doc_id'] = df.apply(lambda x: f"{lp}_#_{x['domain']}_#_{x['docid']}_#_{x['sntid']}", axis=1)
            df['system'] = system
            df['lp'] = lp
            
            hyps_mapping.append(df)
    
    systems = pd.concat(hyps_mapping, ignore_index=True)


    main(domain_mapping, systems, "../../txt/wmt23-humaneval.jsonl")