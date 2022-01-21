using System;

namespace ProblemWhenWeUseConcreteClassAsABaseClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, This Program Help us to illustrate why we need abstract classes when we have concrete class available");

            FullTimeEmployee Fte = new FullTimeEmployee()
            {
                FirstName = "Mary",
                LastName = "June",
                HourForFullTimeEmployee = 10,
                HourlyRate=300,
                Allowances=120
                
            };
            Fte.GetFullName();
            Fte.GetMonthlySalary();

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");



            PartTimeEmployee Pte = new PartTimeEmployee()
            {
                FirstName = "Mary",
                LastName = "august",
                Perhour = 5,
                HourlyRate = 300,
               

            };
            Pte.GetFullName();
            Pte.GetMonthlySalary();

            // but the real Problem arises when we are able to make instance of a Base class
            // it will create a base class object which is not real

            BaseClass Bte = new BaseClass()
            {
                FirstName = "Mary",
                LastName = "September",

            };
            Bte.GetFullName();
            //but what someone try to call GetMonthlysalary
            //it will genrate a run time error
            //main Purpose of declearing a class as abstract is that
            // abstract class deny for creating object from developer
            //which will resolve all this Probelm

            Bte.GetMonthlySalary();
        }
    }
}