using InheritancePolimorphismExample.Business.Services;
using InheritancePolimorphismExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolimorphismExample.Business.Manager
{
    public class HospitalManager : IHospitalService
    {
       

        public void PayAllStaff(List<StaffMember> staffMembers)
        {
            foreach(var member in staffMembers)
            {
                var maas = member.Salary;

                Console.WriteLine($"Çalışanın hakederi {maas}'lik tutar hesabına yatırıldı. ");
            }
        }
    }
}
