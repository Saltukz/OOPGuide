using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public class DiscMag : Magazine
    {
        public DiscMag(string title, double price, int copies) : base(title, price, copies)
        {

        }

        public override void RecNewIssue(string issue)
        {
            base.RecNewIssue(issue);
            currIssue = currIssue + issue + "Disk yok";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
