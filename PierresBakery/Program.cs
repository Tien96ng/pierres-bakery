using System;
using Bakery.Models;

namespace Bakery 
{
  public class Program 
  {
    public static void Main() 
    {
      WelcomePrompt();
      Prompt("Which would you like to buy [B/P/EXIT]: ");
    }

    public static void WelcomePrompt() {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is our Menu:");
      Console.WriteLine($"- Bread: Buy 1 for $5 OR buy 2, get 1 free. ");
      Console.WriteLine($"- Pastry Buy 1 for $2 OR buy 3 for $5");
      Console.WriteLine("");
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

    public static int TryReadInt(string prompt)
    {
      Console.Write(prompt);
      int amount = -1;
      try {
        amount = int.Parse(Console.ReadLine());
      }
      catch
      {
        amount = -1;
      }
      return amount;
    }

    public static void BreadOrder() {
      int amount = TryReadInt("How many loaves of Bread would you like: ");
      while(amount < 0) {
        amount = TryReadInt("Please enter in a VALID number of Bread loaves to buy: ");
      }
      string loaves = amount == 1 ? "loaf" : "loaves";
      Bread newBread = new Bread(amount);
      Console.WriteLine("");
      Console.WriteLine($"Your total for {amount} {loaves} will be ${newBread.BreadCost()}.");
      Console.WriteLine("");
      Prompt("Would you like to continue shopping [B/P/EXIT]: ");
    }

    public static void PastryOrder() {
      int amount =  TryReadInt("How many Pastries would you like: ");
      while(amount < 0) {
        amount = TryReadInt("Please enter in a VALID number of Pastries to buy: ");
      }
      string pastries = amount == 1 ? "Pastry" : "Pastries";
      Pastry newPastry = new Pastry(amount);
      Console.WriteLine("");
      Console.WriteLine($"Your total for {amount} {pastries} will be ${newPastry.PastryCost()}.");
      Console.WriteLine("");
      Prompt("Would you like to continue shopping [B/P/EXIT]: ");
    }
  }
}