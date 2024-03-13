# WMT23 Annotations CSV Format
## Executive Summary
This document describes the CSV file format used for WMT23 human evaluation scores.

## File Structure
Each line contains 11 individual fields, separated by `,`, and encodes a single, human
quality assessment for an individual segment contained in the WMT23 test data.

## Fields
The 11 fields are as follows:

1. `UserID`: contains the annotator's user ID
2. `SystemID`: contains the translation system's ID
3. `SegmentID`: contains the 1-based, document-relative segment ID
4. `Type`: always `TGT` (other values have been filtered out)
5. `SourceLanguage`: source language ISO code
6. `TargetLanguage`: target language ISO code
7. `Score`: segment score, integer, in range [0, 100]
8. `DocumentID`: the document ID for the current segment
9. `IsDocument?`: always `False` (document-level meta scores have been filtered out)
10. `StartTime`: annotation started at this date/time
11. `EndTime`: annotation ended at this date/time