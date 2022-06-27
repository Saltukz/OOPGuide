using Inheritance.Entities;
using Interface;
using Polymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Helper
{
    public static class TypeHelper
    {
        public static void SaleType(ISellableItem item)
        {
            item.DescribeSelf();

        }
    }
}
