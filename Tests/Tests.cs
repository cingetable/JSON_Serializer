global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using JSON_Serializer;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

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
        TestsClass2 testsClass2 = new TestsClass2("this is string", 0, 'a', true);
       
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(testsClass2);
        string expected = "{\"testString\":\"this is string\",\"testInteger\":0,\"testSymbol\":\"a\",\"testBoolean\":true,\"testList\":[\"first elem\",\"second elem\"]}";
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod3() {
        List<object> list = new List<object>();
        list.Add("1elem");
        list.Add("2elem");
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(list);
        string expected = "[\"1elem\",\"2elem\"]";
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod4() {
        List<object> list = new List<object>();
        list.Add(2);
        list.Add(400);
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(list);
        string expected = "[2,400]";
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod5() {
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(5);
        string expected = "5";
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod6() {
        Serializer mySerializer = new Serializer();
        Dictionary<string, object> dict = new Dictionary<string, object>() {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3
        };
        string actual = mySerializer.Serialize(dict);
        string expected = "{\"one\":1,\"two\":2,\"three\":3}";
        Assert.AreEqual(expected, actual);
    }
}