namespace Tests;

public abstract class TestsClass
{
    private string testString;
    private int testInteger;
    private char testSymbol;
    private bool testBoolean;

    public TestsClass(string _testString, int _testInteger, char _testSymbol, bool _testBoolean)
    {
        testString = _testString;
        testInteger = _testInteger;
        testBoolean = _testBoolean;
        testSymbol = _testSymbol;
    }
}
