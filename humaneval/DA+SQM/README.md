# Removing bad references and document-level scores:

```
cat scores_all.csv | python3 scripts/rm_bad_docs.py | grep -v ",True," > scores_noqc_nodoc.csv

```