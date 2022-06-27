using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public abstract class Publication : ISellableItem
    {
        public string Title { get; set; } = null!;

        public double Price { get; set; }

        public int Copies { get; set; }

        public Publication(string title, double price, int copies)
        {
            Title = title;
            Price = price;
            Copies = copies;
        

        }

        public Publication()
        {
           
        }

        public void SellCopy(int qty)
        {
            Copies = Copies -qty;
        }

        public override string ToString()
        {
            return Title;
        }

        public void DescribeSelf()
        {
            Console.WriteLine(ToString());
        }
    }
}
