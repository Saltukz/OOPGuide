
using Inheritance.Entities;
using Interface;
using Polymorphism.CashService;
using Polymorphism.Entities;

public class Program
{
    public static void Main()
    {

        DiscMag discMag = new("dergi1", 12, 30);
        Console.WriteLine(discMag.Copies);

        CashTill cashTill = new();

        cashTill.SellItem(discMag, 5);

        Console.WriteLine(discMag.Copies);
      
    }
  
}