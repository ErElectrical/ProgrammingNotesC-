using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Example2_Parent
    {
        public virtual void show()
        {
            Console.WriteLine("Base class virtual");
        }
    }

    public class Example2_Child: Example2_Parent
    {
        public override void show()
        {
            Console.WriteLine("child class overrride");
        }
    }

}
