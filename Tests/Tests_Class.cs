namespace Tests;
[Serializable]
public class TestsClass
{
    private string testString { get; set; }
    private int testInteger { get; set; }
    private char testSymbol { get; set; }
    private bool testBoolean { get; set; }

    public TestsClass(string _testString, int _testInteger, char _testSymbol, bool _testBoolean)
    {
        testString = _testString;
        testInteger = _testInteger;
        testBoolean = _testBoolean;
        testSymbol = _testSymbol;
    }
}
