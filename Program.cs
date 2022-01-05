using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to starbucks store");

            //In unit testing, we generally need to write code to access the external resource, like a file or
           //database system. But what about when the resource is not available?
          //• This can be solved by using mock objects. Creating fake objects for these underlying dependencies can
          //help you to test the interaction between the method and its dependencies.

            //Mock code functions on its own and no other code can harm it.
              //• The classes to be mocked can’t be static or sealed, and the method being mocked should be
               //marked as virtual.
               // Set and inspect values on a fake object.
               // Inspect method calls and args on a fake object.
        }
    }
}
