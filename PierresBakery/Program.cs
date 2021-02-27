using System;
using Bakery.Models;

namespace Bakery 
{
  public class Program 
  {
    public static void Main() 
    {
      Prompt("Which would you like to buy [B/P/EXIT]: ");
    }

    public static void WelcomePrompt() {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is our Menu:");
      Console.WriteLine($"- Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine($"- Pastry Buy 1 for $2 or 3 for $5");
    }

    public static void Prompt(string msg) {
      Console.Write(msg);
      string userSelection = Console.ReadLine().ToUpper();
      if(userSelection == "EXIT") 
      {
        Console.WriteLine("Have a good day!");
      } 
      else if(userSelection == "B" || userSelection == "P")
      {
        if(userSelection == "B") 
        {
          BreadOrder();
        }
        else
        {
          PastryOrder();
        }
      } 
      else 
      {
        Prompt("INVALID INPUT! Which would you like to buy [B/P/EXIT]: ");
      }
    }

    public static void BreadOrder() {
      Console.Write("How many loaves of Bread would you like: ");
      int amount =  int.Parse(Console.ReadLine());
      string loaves = amount == 1 ? "loaf" : "loaves";
      Bread newBread = new Bread(amount);
      Console.WriteLine("");
      Console.WriteLine($"Your total for {amount} {loaves} will be ${newBread.BreadCost()}.");
      Console.WriteLine("");
      Prompt("Would you like to continue shopping [B/P/EXIT]: ");
    }

    public static void PastryOrder() {
      Console.Write("How many Pastries would you like: ");
      int amount =  int.Parse(Console.ReadLine());
      string pastries = amount == 1 ? "Pastry" : "Pastries";
      Pastry newPastry = new Pastry(amount);
      Console.WriteLine("");
      Console.WriteLine($"Your total for {amount} {pastries} will be ${newPastry.PastryCost()}.");
      Console.WriteLine("");
      Prompt("Would you like to continue shopping [B/P/EXIT]: ");
    }
  }
}