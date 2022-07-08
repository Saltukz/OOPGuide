using InheritancePolimorphismExample.Business.Manager;
using InheritancePolimorphismExample.Entities.Abstract;
using InheritancePolimorphismExample.Entities.Concrete;

class Program
{
    static void Main()
    {
        Console.WriteLine("selam");
        Doctor doctor1 = new();
        doctor1.HoursWorked = 20;
        doctor1.RateOfPay = 50;
        doctor1.CalculatePay();
        Nurse nurse1 = new();
        nurse1.HoursWorked = 20;
        nurse1.RateOfPay = 25;
        nurse1.CalculatePay();
        Doctor doctor2 = new();
        doctor2.HoursWorked = 30;
        doctor2.RateOfPay = 40;
        doctor2.CalculatePay();

        doctor2.Sanal1();
        doctor2.Sanal2();

        //AllHospitalStaff allHospitalStaff = new();
        //allHospitalStaff.AddEmployee(doctor1);
        //allHospitalStaff.AddEmployee(nurse1);
        //allHospitalStaff.AddEmployee(doctor2);

        //HospitalManager manager = new();

        //manager.PayAllStaff(allHospitalStaff.staffMembers);

    }
}