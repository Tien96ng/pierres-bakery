using System;

namespace Bakery.Models 
{
  public class Bread 
  {
    public int BreadAmount { get; }
    public int BreadPrice { get; }

    public Bread(int orderAmount) {
      BreadAmount = orderAmount;
      BreadPrice = 5;
    }

    public int BreadCost() {
      int discount = 0;
      int priceBeforeDiscount = BreadAmount * 5;

      for(int i = 1; i <= BreadAmount; i++) {
        if(i % 3 == 0) {
          discount += 5;
        }
      }
      return priceBeforeDiscount - discount;
    }
  }
}