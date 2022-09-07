using NUnit.Framework;

namespace FirstConsoleApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {    
    }

    [Test]
    public void PassedTest()
    {
        Assert.True(true);
    }

    [Test]
    public void FailedTest()
    {
        Assert.True(false);
    }
}