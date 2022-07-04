namespace Tests;
[Serializable]
public class TestsClass {
    public string testString;
    public int testInteger;
    public char testSymbol;
    public bool testBoolean;

    public TestsClass(string _testString, int _testInteger, char _testSymbol, bool _testBoolean)
    {
        testString = _testString;
        testInteger = _testInteger;
        testBoolean = _testBoolean;
        testSymbol = _testSymbol;
    }
}
public class TestsClass2 {
    public string testString;
    public int testInteger;
    public char testSymbol;
    public bool testBoolean;
    public List<object> testList;
    public TestsClass2(string _testString, int _testInteger, char _testSymbol, bool _testBoolean)
    {
        testString = _testString;
        testInteger = _testInteger;
        testBoolean = _testBoolean;
        testSymbol = _testSymbol;
        testList = new List<object>();
        testList.Add("first elem");
        testList.Add("second elem");
    }
}

