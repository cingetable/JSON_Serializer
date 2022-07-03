global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using JSON_Serializer;
namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        TestsClass testsClass = new TestsClass("this is string", 0, 'a', true);
       
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(testsClass);
        string expected = "{\"testString\":\"this is string\",\"testInteger\":0,\"testSymbol\":\"a\",\"testBoolean\":true}";
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod2()
    {
       
    }
}