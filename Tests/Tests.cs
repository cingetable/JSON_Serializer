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
        string expected = JsonSerializer.Serialize(testsClass);
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(testsClass);
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod2()
    {
        TestsClass_noConstuctor testsClass = new TestsClass_noConstuctor();
        string expected = JsonSerializer.Serialize(testsClass);
        Serializer mySerializer = new Serializer();
        string actual = mySerializer.Serialize(testsClass);
        Assert.AreEqual(expected, actual);
    }
}