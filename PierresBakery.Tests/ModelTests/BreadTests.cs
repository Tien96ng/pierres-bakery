using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests 
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread() {
      Bread newBread = new Bread(1);
      Assert.AreEqual(1, newBread.BreadAmount);
    }

    [TestMethod]
    public void BreadCostMethod_ReturnsCostOfBread_Int()
    {
      Bread newBread = new Bread(10);
      int result = 35;
      Assert.AreEqual(result, newBread.BreadCost());
    }
  }
}