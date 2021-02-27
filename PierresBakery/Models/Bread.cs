using System;

namespace Bakery.Models 
{
  public class Bread 
  {
    public int BreadAmount { get; }
    public int BreadPrice { get; }

    public Bread(int orderAmount) 
    {
      BreadAmount = orderAmount;
      BreadPrice = 5;
    }

    public int BreadCost() 
    {
      return (BreadAmount * BreadPrice) - (BreadAmount / 3 * BreadPrice);
    }
  }
}