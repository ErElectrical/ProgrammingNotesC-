using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemWhenWeUseConcreteClassAsABaseClass
{
    public class FullTimeEmployee : BaseClass
    {
        public int HourlyRate { get; set; }

        public int HourForFullTimeEmployee { get; set; }

        public int Allowances { get; set; }

        public override void GetMonthlySalary()
        {
            Console.WriteLine("Monthly Salary is : {0} ", (HourForFullTimeEmployee * HourlyRate) + Allowances);
        }
    }
}
