using System;

namespace Bakery.Models 
{
  public class Bread 
  {
    public int BreadAmount { get; }

    public Bread(int orderAmount) {
      BreadAmount = orderAmount;
    }

    public int BreadCost(int orderAmount) {
      return orderAmount;
    }
  }
}