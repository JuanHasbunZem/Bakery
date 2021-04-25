using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int pastryTotal { get; set; }

    public Pastry(int pastryNumber)
    {
      pastryTotal = pastryNumber;
    }

    public int FindTotal()
    {
      int fullPrice = pastryTotal * 2;
      int anyDeals = pastryTotal%3;
      int newTotal = 0;
      int finalPrice = 0;

      if (anyDeals >= 0)
      {
        newTotal = ((pastryTotal%3)*2) + ((pastryTotal/3)*5);
        finalPrice = newTotal;
        return finalPrice;
      } 
      else
      {
        newTotal = (pastryTotal - anyDeals)/3;
        finalPrice = (pastryTotal - newTotal) * 3;
        return finalPrice;
      }
    }
  }
}