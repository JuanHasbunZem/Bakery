using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void IsPastry_ObjectCreated_True()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void PastryObj_ReturnsNumber_True()
    {
      Pastry testPastry = new Pastry(15);
      Assert.AreEqual(15, testPastry.pastryTotal);
    }
    
    [TestMethod]
    public void PastryObj_CalcsTotal()
    {
      Pastry testPastry = new Pastry(3);
      Assert.AreEqual(5, testPastry.FindTotal());
    }
  }
}