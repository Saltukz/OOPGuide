using InheritancePolimorphismExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolimorphismExample.Business.Services
{
    public interface IHospitalService
    {
        void PayAllStaff(List<StaffMember> staffMembers);
    }
}
