using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBread_ObjectCreated_True()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void BreadObj_ReturnsNumber_True()
    {
      Bread testBread = new Bread(15);
      Assert.AreEqual(15, testBread.breadTotal);
    }
    
    [TestMethod]
    public void BreadObj_CalcsTotal()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(10, testBread.FindTotal());
    }
  }
}