using System;

namespace MethodOverriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Method Overriding tutorial");

            //Method Overriding is a technique that allows the invoking of functions from another class (base class)
            //in the derived class.
            //Creating a method in the derived class with the same signature
            //as a method in the base class is called as method overriding. 

            //Overriding is a feature that allows a subclass or child class to provide a specific implementation of a method
            //that is already provided by one of its super-classes or parent classes.
            //When a method in a subclass has the same name, same parameters or signature and same return type(or sub-type)
            //as a method in its super-class, then the method in the subclass is said to override the method in the super-class.
            //Method overriding is one of the ways by which C# achieve Run Time Polymorphism(Dynamic Polymorphism).

            //The overridden base method must be virtual, abstract, or override.

            //Method overriding can be done in 3 ways 

            // 'obj' is the object of
            // class 'baseClass'
            Parent obj = new Parent();


            // invokes the method 'show()'
            // of class 'baseClass'
            obj.show();

            // we dont create another object for child class 
            // insisted we just change reference of the object obj
            // previously it has refernce of method in parent class but now it has refernce of method in child class

            // obj=new Child();
            //changing the refernce of object doesnot work for us because of no use of virtual and override keyword.
            Child ob = new Child();

            // it also invokes the method
            // 'show()' of class 'baseClass'
            ob.show();

            Example2_Parent exam = new Example2_Parent();

            exam.show();

            // we are successfull here to change refernce because virtual,override keyword is decleared in it 
            // to achieve method overriding.

            exam = new Example2_Child();

            exam.show();


            // 'E' is object of class stream
            // also works as object of
            // class 'web'
            stream E = new stream();


            // it first invokes 'showdata()'
            // of class 'web' then it invokes
            // 'showdata()' of class 'stream'
            E.showdata();

            // invoke no argumanet constructor
            DerivedClass d1 = new DerivedClass();

            Console.WriteLine();

            // invoke parameterized constructor
            DerivedClass d2 = new DerivedClass(10, 20);

            // invoke no argumanet constructor
            DerivedClassBase d3 = new DerivedClassBase();

            Console.WriteLine();

            // invoke parameterized constructor
            DerivedClassBase d4 = new DerivedClassBase(10, 20);

            // calling swap function
            d4.swap();



        }


    }
}
