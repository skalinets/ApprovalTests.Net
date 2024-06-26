public class NonNUnitReporterTest
{
    [Fact]
    public void TestNunitIsNotWorkingFromXUnit()
    {
        Approvals.SetCaller();
        Assert.False(NUnit4Reporter.INSTANCE.IsWorkingInThisEnvironment("default.txt"));
    }

    [Fact]
    public void TestXunitIsWorking()
    {
        Approvals.SetCaller();
        Assert.True(XUnit2Reporter.INSTANCE.IsWorkingInThisEnvironment("default.txt"));
    }

    [Fact]
    public void TestXunitReporterIsWorking()
    {
        var e = ExceptionUtilities.GetException(() => XUnit2Reporter.INSTANCE.AssertEqual("Hello", "Hello2"));
        Approvals.Verify(e.Message);
    }
}