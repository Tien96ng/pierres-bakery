using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests 
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry() {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.PastryAmount);
    }

    [TestMethod]
    public void PastryConstructor_PastryBasePrice_Pastry() {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(5, newPastry.PastryPrice);
    }

    [TestMethod]
    public void PastryCostMethod_ReturnsCostOfPastry_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = 23;
      Assert.AreEqual(result, newPastry.PastryCost());
    }
  }
}