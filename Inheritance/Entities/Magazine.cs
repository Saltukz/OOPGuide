using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public class Magazine : Publication
    {
        public Magazine(string title, double price, int copies) : base(title, price, copies)
        {
        }

        public int OrderQty { get; set; }

        public string? currIssue { get; set; }

        public void AdjustQty(int qty)
        {
            OrderQty = qty;
        }

        public virtual void RecNewIssue(string issue)
        {

            currIssue = "Magazin sorunları";
        }


    }
}
