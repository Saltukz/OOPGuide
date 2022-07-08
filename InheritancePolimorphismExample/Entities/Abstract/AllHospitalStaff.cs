using InheritancePolimorphismExample.Business.Manager;
using InheritancePolimorphismExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolimorphismExample.Entities.Abstract
{
    public class AllHospitalStaff
    {
        public List<StaffMember> staffMembers = new List<StaffMember>();
        public void AddEmployee(StaffMember staffMember)
        {
            Console.WriteLine("Yeni Çalışan Eklendi.");
            staffMembers.Add(staffMember);
        }

        public void RemoveEmployee(StaffMember staffMember)
        {
            Console.WriteLine("Çalışan kovuldu.");
            staffMembers.Remove(staffMember);
        }

        public virtual void Sanal1() => Console.WriteLine("ben Sanal1'im");

        public virtual void Sanal2() => Console.WriteLine("ben Sanal2'yim");
        
    }
}
