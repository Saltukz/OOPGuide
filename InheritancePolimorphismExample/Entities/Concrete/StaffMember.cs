using InheritancePolimorphismExample.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolimorphismExample.Entities.Concrete
{
    public class StaffMember : AllHospitalStaff
    {
        public double RateOfPay { get; set; }

        public int HoursWorked { get; set; }

        public double Salary { get; set; }
        public double CalculatePay()
        {
            Salary = RateOfPay * HoursWorked;
            return RateOfPay * HoursWorked;
        }
    }
}
