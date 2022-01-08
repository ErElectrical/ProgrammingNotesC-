using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class DelegateExample
    {

        //there are two delegates addnum and subnum.
        //We are creating the object obj of the class Geeks because both the methods(addnum and subnum) are instance methods.
        //So they need an object to call.
        //If methods are static then there is no need to create the object of the class.

        public delegate void  addnum(int x, int y);
        public delegate void multiple(int x, int y, int z);

        public void Addnum(int x, int y)
        {
            Console.WriteLine("sum is {0} ", x + y);
        }

        public void Mul(int x, int y,int z)
        {
            Console.WriteLine("multiple is {0} ", x * y * z);
        }

    }
}
