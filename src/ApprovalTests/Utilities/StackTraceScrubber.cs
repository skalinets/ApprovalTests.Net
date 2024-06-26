namespace ApprovalTests.Utilities;

public static class StackTraceScrubber
{
    public static string ScrubAnonymousIds(string source)
    {
        var regex = new Regex(@"\w+__\w+");
        return regex.Replace(source, string.Empty);
    }

    public static string ScrubLineNumbers(string source)
    {
        var regex = new Regex(@":line \d+");
        return regex.Replace(source, string.Empty);
    }

    static Regex windowsPathRegex = new(@"\b\w:[\\\w.\s-]+\\");
    static Regex unixPathRegex = new(@"\/[\/\w.\s-]+\/");

    public static string ScrubPaths(string source)
    {
        var result = windowsPathRegex.Replace(source, "...\\");
        result = unixPathRegex.Replace(result, ".../");
        return result;
    }

    public static string ScrubStackTrace(this string text) =>
        ScrubberUtils.Combine(ScrubAnonymousIds, ScrubPaths, ScrubLineNumbers)(text);

    public static string Scrub(this Exception exception) =>
        ("" + exception).ScrubStackTrace();
}