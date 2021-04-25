using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int breadTotal { get; set; }

    public Bread(int breadNumber)
    {
      breadTotal = breadNumber;
    }

    public int FindTotal()
    {
      int fullPrice = breadTotal * 5;
      int includeDeal = breadTotal%3;
      int newTotal = (breadTotal - includeDeal)/3;
      int finalPrice = (breadTotal - newTotal) * 5;

      return finalPrice;
    }
  }
}
