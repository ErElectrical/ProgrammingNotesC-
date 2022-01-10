using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Parent
    {

        //Example 1: Method Overriding without using virtual and override modifiers

        public void show()
        {
            Console.WriteLine("Base class");
        }



    }

    public class Child:Parent
    {
        // overriding

        //if no virtual , keyword is use in parent class than 
        // with new keyword we can acheive method overriding in child class 

        new public void show()
        {
            Console.WriteLine("child class");

        }
    }
}
