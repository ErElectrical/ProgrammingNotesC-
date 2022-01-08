using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MulticastDelegates
    {

        //Multicasting of delegate is an extension of the normal delegate(sometimes termed as Single Cast Delegate).
        //It helps the user to point more than one method in a single call.
        // Properties: 


        //Delegates are combined and when you call a delegate then a complete list of methods is called.
        //   All methods are called in First in First Out(FIFO) order.
        //   ‘+’ or ‘+=’ Operator is used to add the methods to delegates.
        //   ‘–’ or ‘-=’ Operator is used to remove the methods from the delegates list.

        //Remember
        //multicasting of delegate should have a return type of Void otherwise it will throw a runtime exception.
        //Also, the multicasting of delegate will return the value only from the last method added in the multicast.
        //Although, the other methods will be executed successfully.

        // create a delegate return type must be void as we have to use it in multicast
        public delegate void Areafunc(double height,double width);

        // "area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }






    }
}
