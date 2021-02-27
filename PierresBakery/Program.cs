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
      Console.WriteLine($"- Bread {0}");
      Console.WriteLine($"- Pastry {0}");
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
      Console.Write("How many loaves of Brad would you like: ");
      int breadAmount =  int.Parse(Console.ReadLine());
      string loaves = breadAmount == 1 ? "loaf" : "loaves";
      Bread newBread = new Bread(breadAmount);
      Console.WriteLine("");
      Console.WriteLine($"Your total for {breadAmount} {loaves} will be ${newBread.BreadCost()}.");
      Console.WriteLine("");
      Prompt("Would you like to continue shopping [B/P/EXIT]: ");
    }

    public static void PastryOrder() {
      Console.WriteLine("Pastry");
    }
  }
}