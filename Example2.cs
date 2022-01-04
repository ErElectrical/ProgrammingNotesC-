using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DotNetReflections
{
    public class Example2
    {
        //In this code, we use reflection to show all the metadata related to the program which includes classes,
        //methods of these classes and the parameters associated with these parameters.


        // Properties definition

        public string name { get; set; }
        public int Rollno { get; set; }

        // No parameter constructor
        public Example2()
        {
            name = string.Empty;
            Rollno = 0;

        }

        // parametrised constructor
        public Example2(string n, int roll)
        {
            name = n;
            Rollno = roll;

        }
        // Method to Display Student Data
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", Rollno);
            Console.WriteLine("Name : {0}", name);
        }
    }
    class gfg
    {
        static void Main(string[] args)
        {
           // Declare Instance of class Assembly
           //ll the GetExecutingAssembly method
        // to load the current assembly
        Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();

            // reason 
            foreach(var t in types)
            {
                // an hirarchy is require to get information about things
                //like we do here
                //first we search for classes
                //than by using classes objects we find   method
                //it is because methods are presents inside a class
                // and by using method objects we call for the parameters 
                //
                Console.WriteLine("class : {0} ", t.Name);

                MethodInfo[] infomethod = t.GetMethods();
                foreach (var fn in infomethod)
                {
                    Console.WriteLine("class : {0} ", fn.Name);


                    ParameterInfo[] infoparameter = fn.GetParameters();
                    foreach(var para in infoparameter)
                    {
                        Console.WriteLine("parameter name : {0} type : {1} ", para.Name, para.ParameterType);
                    }
                }
            }

            


        }
    }
}
