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
      Bread newBread = new Bread(1);
      int orderAmount = 10;
      Console.WriteLine(newBread.BreadCost(10));
      Assert.AreEqual(orderAmount, newBread.BreadCost(10));
    }
  }
}