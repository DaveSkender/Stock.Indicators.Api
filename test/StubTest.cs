using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Common;

namespace Tests;

[TestClass]
public class AdlTests : TestBase
{
    [TestMethod]
    public void StubPass()
    {
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void StubFail()
    {
        Assert.Fail();
    }

    [TestMethod]
    public void StubInconclusive()
    {
        Assert.Inconclusive();
    }
}
