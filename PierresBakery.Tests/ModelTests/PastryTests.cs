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

  }
}