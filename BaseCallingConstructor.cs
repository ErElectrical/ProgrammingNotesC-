using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class clssA
    {
        // How base keyword specifies the calling of base-class constructor from derived class
        // when derived class instances are created.

        int n1, n2;

        // default constructor
        public clssA()
        {
            Console.WriteLine("Default Constructor Invoked");
        }

        // parameterized constructor
        public clssA(int i, int j)
        {

            // construct values
            n1 = i;
            n2 = j;
            Console.WriteLine("Parameterized Constructor Invoked");
            Console.WriteLine("Invoked Values are: " + n1 + " and " + n2);
        }

    }

    public class DerivedClass : clssA
    {

        // This constructor will instantiate
        // 'clssA()' [no argument constructor]
        // using 'base' keyword
        public DerivedClass() : base() { }


        // This constructor will instantiate
        // 'clssA(int i, int j)' [parameterized
        // constructor] using 'base' keyword
        public DerivedClass(int i, int j) : base(i, j) { }


    }
}