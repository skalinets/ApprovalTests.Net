﻿using DiffEngine;

namespace ApprovalTests.Reporters;

public class DiffMergeReporter : DiffToolReporter
{
    public static readonly DiffMergeReporter INSTANCE = new();

    public DiffMergeReporter() : base(DiffTool.DiffMerge)
    {
    }
}