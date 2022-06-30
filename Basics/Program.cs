
using Inheritance.Entities;
using Inheritance.Helper;
using Polymorphism.CashService;

public class Program
{
    public static void Main(string[] args)
    {
        //DiscMag discMag = new DiscMag("dergi", 10, 50);
        //CashTill cashTill = new();
        //cashTill.SellItem(discMag, 5);
        //Console.WriteLine(discMag.Copies);
        //TypeHelper.SaleType(discMag);

        Coordinate kordinat = new Coordinate();
        kordinat.x = 5;
        kordinat.y = 3;

        int a = 10;
        int p;
        float q = 0.4F;
        object b = a;
        p = (int)b;

        Console.WriteLine("p nin degeri = {0} \n q nun degeri {1}",p,q);


        int x = 2000000000;
        int y = 2000000000;
        
        int xy = unchecked(x + y);
        Console.WriteLine(xy);

        char[] k = { 'a', 'b', 'c', 'd', 'e', 'f' };

        string str = new string(k);
        Console.WriteLine(str);
    }

    struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public void SetOrigin()
        {
            x = 0;
            y = 0;
        }
    }





}