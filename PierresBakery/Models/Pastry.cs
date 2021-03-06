namespace Bakery.Models {
  public class Pastry {
    public int PastryAmount { get; }
    public int PastryPrice { get; }

    public Pastry(int orderAmount) 
    {
      PastryAmount = orderAmount;
      PastryPrice = 2;
    }

    public int PastryCost() {
      int total = 0;
      for(int i = 1; i <= PastryAmount; i++) 
      {
        total += PastryPrice;
        if(i % 3 == 0) {
          total -= 1;
        }
      }
      return total;
    }
  }
}