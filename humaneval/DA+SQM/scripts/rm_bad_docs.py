#!/usr/bin/env python3

import sys

FIELD_USER_ID = 0
FIELD_SYS_ID = 1
FIELD_ITEM_ID = 2
FIELD_ITEM_TYPE = 3
FIELD_SRC_LANG = 4
FIELD_TRG_LANG = 5
FIELD_SCORE = 6
FIELD_DOC_ID = 7
FIELD_DOC_TYPE = 8
FIELD_TIME_START = 9
FIELD_TIME_END = 10


isbad = False
lines = []


def doc_key(fields):
    return "|".join(fields[i] for i in [FIELD_USER_ID, FIELD_SYS_ID, FIELD_DOC_ID])


for line_no, line in enumerate(sys.stdin):
    fields = line.rstrip('\n').split(',')

    if len(fields) != 11:
        sys.stderr.write(f'Error: incorrect number of fields in line {line_no}\n')
        exit()

    # assert if sorted
    # if len(lines) > 0 and doc_key(fields) != doc_key(lines[-1].split(',')):
    # sys.stderr.write(f'Error: scores does not seem to be sorted, see line {line_no}\n')
    # exit()

    prev_fields = lines[-1].split(",") if lines else []

    if (prev_fields and prev_fields[FIELD_DOC_TYPE] == "True") or (
        len(lines) > 0 and doc_key(fields) != doc_key(prev_fields)
    ):
        if not isbad:
            sys.stdout.write("".join(lines))
        isbad = False
        lines = []

    if fields[FIELD_ITEM_TYPE] == "BAD":
        isbad = True
    lines.append(line)

if len(lines) > 0 and not isbad:
    sys.stdout.write("".join(lines))
