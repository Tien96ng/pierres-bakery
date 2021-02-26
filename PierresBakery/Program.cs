using System;

namespace Bakery 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is our Menu:\n - Bread ${BREAD_PRICE_PLACEHOLDER}\n - Pastry ${BREAD_PRICE_PLACEHOLDER}");
      
      Prompt("Which would you like to buy [B/P/EXIT]: ");

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
        Console.WriteLine("Bread and Pastry PlaceHolder Prompts for Amount to buy.");
      } 
      else 
      {
        Prompt("INVALID INPUT! Which would you like to buy [B/P/EXIT]: ");
        // userSelection = Console.ReadLine().ToUpper();
      }
    }
  }
}