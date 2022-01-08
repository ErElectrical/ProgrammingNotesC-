using System;
using System.Collections.Generic;

namespace Genrics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to genrics concepts");

        //Generic is a class which allows the user to define classes and methods with the placeholder.
        //Generics are commonly used to create type-safe collections for both reference and value types.
        //The .NET framework provides an extensive set of interfaces and classes in the System.Collections.Generic namespace for implementing generic collections.
        //type safe simply means that we have to pass only that argument which is decleared during initializing of that method.
        // genrics increase the code reusibility  because with the help of genrics we dont need to write type specific code again
        // we can use already defined method by passing the required data type parameter.

        //Features of Generics

        // Generics is a technique that improves your programs in many ways such as:

        //It helps you in code reuse, performance and type safety.
        //You can create your own generic classes, methods, interfaces and delegates.
        //You can create generic collection classes. The.NET framework class library contains many new generic collection classes in System.Collections.Generic namespace.
        //You can get information on the types used in generic data type at run-time.

        //Advantages of Generics

        //Reusability: You can use a single generic type definition for multiple purposes in the same code
        //without any alterations.For example, you can create a generic method to add two numbers.
        //This method can be used to add two integers as well as two floats without any modification in the code.

        //  Type Safety:
        //  Generic data types provide better type safety, especially in the case of collections.
        //  When using generics you need to define the type of objects to be passed to a collection.
        //  This helps the compiler to ensure that only those object types that are defined in the definition
        //  can be passed to the collection.

         //Performance:
         //Generic types provide better performance as compared to normal system types
         //because they reduce the need for boxing, unboxing, and typecasting of variables or objects.



           Genrics<string> genrics = new Genrics<string>();
            genrics.value = "mohit";
            Console.WriteLine(genrics.data);

            Genrics<int> genric = new Genrics<int>();
            genric.value = 23;

            Console.WriteLine(genric.data);

            GenricExample gen = new GenricExample();
            gen.display<int>("integer", 23);
            gen.display<float>("integer", 23.9f);
            gen.display<string>("string", "ch");






        }
    }
}
