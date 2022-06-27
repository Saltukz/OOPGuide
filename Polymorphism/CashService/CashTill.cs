using Inheritance.Entities;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.CashService
{
    public class CashTill
    {
        private double runningTotal;

        public CashTill()
        {
            runningTotal = 0;
        }

        public void SellItem(ISellableItem item ,int qty)
        {
            runningTotal = runningTotal + item.Price * qty;
            item.SellCopy(qty);

            Console.WriteLine("Sold " + item + " @ " + item.Price + "\nSubtotal = " + runningTotal);
        }

        public void ShowTotal()
        {
            Console.WriteLine("Grand Total: " + runningTotal);
        }
    }
}
