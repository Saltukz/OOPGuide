using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public class Book : Publication
    {
        public Book(string title, double price, int copies, string author) : base(title, price, copies)
        {
            Author = author;
        }

        public Book()
        {

        }


        public string Author { get; set; } = null!;

        public void OrderCopies(int quantity)
        {
            Copies += quantity;
        }

        public override string ToString()
        {
            return base.ToString() + " by " + Author;
        }
    }

}
