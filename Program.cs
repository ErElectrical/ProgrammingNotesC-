using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome To Method overloading Tutorial");
            //Method Overloading is the common way of implementing polymorphism.
            //It is the ability to redefine a function in more than one form.
            //A user can implement function overloading by defining two or more functions in a class sharing the same name.
            //C# can distinguish the methods with different method signatures.
            //i.e. the methods can have the same name but with different parameters list
            //(i.e. the number of the parameters, order of the parameters, and data types of the parameters)
            //within the same class. 

            //The compiler does not consider the return type while differentiating the overloaded method.
            //But you cannot declare two methods with the same signature and different return type.
            //It will throw a compile-time error.
            //If both methods have the same parameter types, but different return type, then it is not possible.

            //Different ways of doing overloading methods- 
            // Method overloading can be done by following ways
            // The number of parameters in two methods.
            //The data types of the parameters of methods.
            //The Order of the parameters of methods.

            NoOfParameter ob = new NoOfParameter();

            //only difference is number of arguments which method takes as an arguments

            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);

            ChangeDataType obj = new ChangeDataType();

            int sum = obj.Add(1, 2);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum);
            double sum3 = obj.Add(1.0, 2.0);
            Console.WriteLine("sum of the three "
                              + "double value : " + sum3);

            // Creating Object

            //order Of arguments is difference
            ByChangeingParameterType objm = new ByChangeingParameterType();

            objm.Identity("Akku", 1);
            objm.Identity(2, "Abby");



        }
    }
}
