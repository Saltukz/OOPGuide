using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolimorphismExample.Entities.Concrete
{
    public class Doctor : StaffMember
    {
        public override void Sanal1()
        {
            base.Sanal1();
        }

        public override void Sanal2()
        {
            base.Sanal2();
        }

    }
}
