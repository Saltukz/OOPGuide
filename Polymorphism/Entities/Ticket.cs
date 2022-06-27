using Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Entities
{
    public class Ticket : ISellableItem
    {
        public double Price { get; set; }

        public void DescribeSelf()
        {
            Console.WriteLine(ToString());
        }

        public void SellCopy(int qty)
        {
            Console.WriteLine("************************");
            Console.WriteLine("   Ticket Voucher   ");
            Console.WriteLine(ToString()); ;
            Console.WriteLine("************************");

        }
    }
}
