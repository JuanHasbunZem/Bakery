using System;
using Bakery.Models;

namespace Bakery
{
 public class Program
  {
    public static void Main()
    {
      Console.WriteLine("###########  PIERRES BAKERY ###########");
      Console.WriteLine("###########      Welcome!   ###########");
      Console.WriteLine("Welcome!, to Pierre's Bakery! Where we sell high quality artisan breads and pastries at the best prices!");
      Console.WriteLine("For a limited time, enjoy our special offers when ordering from Pierre.");
      Console.WriteLine("Right now, our breads are $5 each, and if you buy 2 you get the third one free!!");
      Console.WriteLine("And our Pastrys are $2 each, or for $5 if you buy 3!!");
      Console.WriteLine("#######################################");
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("How many orders of Bread would you like to purchase?");
      int breadOrder = int.Parse(Console.ReadLine());
      Bread breadNumber = new Bread(breadOrder);
      Console.WriteLine();
      Console.WriteLine("And how many pastries would you like to add?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Pastry pastryNumber = new Pastry(pastryOrder);
      Console.WriteLine();
      int breadTotal = breadNumber.FindTotal();
      int pastryTotal = pastryNumber.FindTotal();
      int finalTotal = breadTotal + pastryTotal;
      Console.WriteLine("Your order total is: $" + finalTotal + ".00.  Thank you for your purchase.");
    }
  }
}