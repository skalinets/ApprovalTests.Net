# Getting Started with Reporters

toc


## Configuring Reporters

Reporters are set using the `[UseReporter(typeof(YourReporter))]` attribute. This can occur in 3 different places, and will be used in order of least surprise.

1. On the method
1. On the Class
1. On the assembly

## When to use different reporters

Reporters help you in different ways

1. To see differences in your test results
1. To see how a test result would render
1. To explore a test result or domain 
1. To approve / manipulate a test result

Based on what you are doing, you will want to switch which reporter you are using. Maybe even use multiple reporters at a time to acomplish different roles.

### Differences

The main use for seeing differeneces is to use a reporter that will open a DiffTool. [Full list of supported diff tools here](Reporters.md#supported-diff-tools)

### Rendering 
Let's say your test result is some HTML. In the beginning you might want to render it in a bowser to be able to see that it is indeed what you want. In this moment, try the  `FileLauncherReporter`. Which will open the `.received.` file in the application associated to it on your machine.

This is useful for many types of test results including, xml, svg, csv, html, images, sound files, etc...

### Exploring Results

Like rendering, you might need to use different tools to examine a file to see that it's what you actually want. Sometimes you need to open them in excel or other places just to play. If you don't have a reporter that will open in your desired tool (and you don't want to [build a custom one](Reporters.md#)) you might just want to use the `QuiteReporter` which will do nothing, allowing you to open whatever you need without distruption

### Approving

DiffTools can be a great way to approve most text files (just copy everything to the `.approved.` file.) However, some DiffTools will break this because they are trying to help (prettifing, triming or otherwise formatting the text)
The `ClipboardReporter` or `AllFailingTestsClipboardReporter` can be useful in these cases. Writing the command line text to move the files to your clipboard so you can paste them into your terminal to approve the test.


---

[Back to User Guide](readme.md#top)