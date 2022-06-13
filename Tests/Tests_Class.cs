namespace Tests;
[Serializable]
public class TestsClass
{
    public string testString { get; set; }
    public int testInteger { get; set; }
    public char testSymbol { get; set; }
    public bool testBoolean { get; set; }

    public TestsClass(string _testString, int _testInteger, char _testSymbol, bool _testBoolean)
    {
        testString = _testString;
        testInteger = _testInteger;
        testBoolean = _testBoolean;
        testSymbol = _testSymbol;
    }
}

public class TestsClass_noConstuctor
{
    public string testString { get; set; }
    public int testInteger { get; set; }
    public char testSymbol { get; set; }
    public bool testBoolean { get; set; }
}
