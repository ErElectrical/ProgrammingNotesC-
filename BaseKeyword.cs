using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    //base Keyword: This is used to access members of the base class from derived class.
    //It basically used to access constructors and methods or functions of the base class.
    //The base keyword cannot use within a static method.
    //Base keyword specifies which constructor of the base class should be invoked
    //while creating the instances of the derived class.
    //Use of Base keyword: 

    //Call methods or functions of base class from derived class.
    //Call constructor internally of base class at the time of inheritance.

     public class BaseKeyword_Parent
    {
        string name = "Geeks Hello";

        // 'showdata()' is member method,
        // declare as virtual
        public virtual void showdata()
        {
            Console.WriteLine("Website Name: " + name);
        }
    }
    // derived class
    // class 'web' is inherits
    // class 'stream'
    class stream : BaseKeyword_Parent
    {


        string s = "Computer Science";

        //'showdata()' is overridden
        // in derived class
        public override void showdata()
        {

            // Calling 'showdata()' of base
            // class using 'base' keyword
            base.showdata();

            Console.WriteLine("About: " + s);
        }
    }
}
