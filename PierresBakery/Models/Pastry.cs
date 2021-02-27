using System;

namespace Bakery.Models {
  public class Pastry {
    public int PastryAmount { get; }
    public int PastryPrice { get; }

    public Pastry(int orderAmount) {
      PastryAmount = orderAmount;
      PastryPrice = 5;
    }

    public int PastryCost() {
      return (PastryAmount * PastryPrice) - (PastryAmount / 2 * 5);
    }
  }
}