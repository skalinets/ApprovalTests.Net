<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /docs/ApprovalTests/howtos/mdsource/CustomizingDiffToolSelectionOrder.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# How to customize the order of DiffTools in your Reporter

<!-- toc -->
## Contents

    * [Choosing a DiffTool preference](#choosing-a-difftool-preference)<!-- endToc -->


### Choosing a DiffTool preference

If you do not like the default order that DiffTools are chosen, you can easily create a custom Reporter with your own preferences.  
Once you create the class, you select it with the `[UseReporter(typeof(CustomDiffReporter))]`

<!-- snippet: CustomDiffReporter.cs -->
<a id='snippet-CustomDiffReporter.cs'></a>
```cs
public class CustomDiffReporter :
    FirstWorkingReporter
{
    public CustomDiffReporter()
        : base(
            //TODO: re-order or remove as required
            BeyondCompareReporter.INSTANCE,
            TortoiseDiffReporter.INSTANCE,
            AraxisMergeReporter.INSTANCE,
            P4MergeReporter.INSTANCE,
            WinMergeReporter.INSTANCE,
            KDiff3Reporter.INSTANCE,
            VisualStudioReporter.INSTANCE,
            RiderReporter.INSTANCE,
            FrameworkAssertReporter.INSTANCE,
            QuietReporter.INSTANCE
        )
    {
    }
}
```
<sup><a href='/src/ApprovalTests.Tests/Reporters/CustomDiffReporter.cs#L1-L20' title='Snippet source file'>snippet source</a> | <a href='#snippet-CustomDiffReporter.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

You can also override the default order while using `DiffReporter` by defining `DiffEngine_ToolOrder` environment variable. The value of that variable should contain a delimiter (`,`, `|`, ` `) separated list of the diff tool names in the desired order. More details about that in [Diff Tool Order](https://github.com/VerifyTests/DiffEngine/blob/main/docs/diff-tool.order.md)

---

[Back to User Guide](../readme.md#top)
