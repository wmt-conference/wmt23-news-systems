# WMT23 News Systems and Evaluations

This repository contains all primary submissions for the WMT23 news task, and the human evaluations.
The submissions are in the following directories

* `xml` : One xml file for each language pair, containing source, reference(s) and hypotheses
* `txt-ts` : Sources, references and hypotheses in text files, including test suites
* `txt` : Same, but without test suites

Tools for extracting the raw text from the XML can be found [here](https://github.com/wmt-conference/wmt-format-tools).

The human evaluations are in the `humaneval` directory.


# Translator IDs

Since references have been prepared by a set of translators and it could be useful when investigating the Hebrew refA possible postedited reference from ONLINE-A.

For English-Hebrew refA:
- all the mastodon and user review texts were translated by one person (id1)
- all the news and speech 0,1,2,3,4,6 - by the second person (id2)
- all the rest speech - by the third one (id3)
