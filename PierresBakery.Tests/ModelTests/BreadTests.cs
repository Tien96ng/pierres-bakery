using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void BreadCostMethod_ReturnsCostOfBread_Int()
    {
      int orderAmount = 10;
      Assert.AreEqual(0, Bread.BreadCost(10));
    }
  }
}