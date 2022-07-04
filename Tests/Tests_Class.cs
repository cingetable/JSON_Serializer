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
public class TestsClass2
{
    public string testString { get; set; }
    public int testInteger { get; set; }
    public char testSymbol { get; set; }
    public bool testBoolean { get; set; }
    public List<string> testList { get; set; }
    public TestsClass2(string _testString, int _testInteger, char _testSymbol, bool _testBoolean)
    {
        testString = _testString;
        testInteger = _testInteger;
        testBoolean = _testBoolean;
        testSymbol = _testSymbol;
        testList = new List<string>();
        testList.Add("first elem");
        testList.Add("second, elem");
    }
}

