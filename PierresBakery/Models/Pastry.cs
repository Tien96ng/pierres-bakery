using System;

namespace Bakery.Models {
  public class Pastry {
    public int PastryAmount { get; }
    public int PastryPrice { get; }

    public Pastry(int orderAmount) {
      PastryAmount = orderAmount;
      PastryPrice = 2;
    }

    public int PastryCost() {
      return (PastryAmount * PastryPrice) - (PastryAmount / 2 * 2);
    }
  }
}