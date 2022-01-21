using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemWhenWeUseConcreteClassAsABaseClass
{

    /* we are going to take example of Employee to understand it
     * employee can have two type parttime,Full time
     * both have common fields 
     * and different too
     * so we can create a Base class With common Points in both classes.
     * it hepls us in Code maintainbility and also we are able to keep DRY principle alive.
     */
    public class BaseClass
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public int MonthlySalary { get; set; }

        public void GetFullName()
        {
            Console.WriteLine("Full Name is " + FirstName + LastName);
        }


        // Method is virtal because we have to 
        // define it in other classes according to requirement
        public virtual void GetMonthlySalary()
        {
            throw new NotImplementedException();
        }

    }
}
