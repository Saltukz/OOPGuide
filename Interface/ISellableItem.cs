using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ISellableItem
    {
        double Price { get; }

        void SellCopy(int qty);

        void DescribeSelf();
    }
}
