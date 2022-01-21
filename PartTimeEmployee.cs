using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemWhenWeUseConcreteClassAsABaseClass
{
    public class PartTimeEmployee:BaseClass
    {
        public int HourlyRate { get; set; }

        public int Perhour { get; set; }

        public override void GetMonthlySalary()
        {
            Console.WriteLine("Monthly Salary is : {0} ", HourlyRate * Perhour);
        }

    }
}
