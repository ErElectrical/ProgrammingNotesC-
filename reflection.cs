using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DotNetReflections
{
    public class reflection
    {
        //Reflection is the process of describing the metadata of types, methods and fields in a code.
        //The namespace System.Reflection enables you to obtain data about the loaded assemblies,
        //the elements within them like classes, methods and value types.

        //some of the common Reflections we use are 

        //1.Assembly---------- describes an assembly which is a reusable, versionable, and self-describing
        //                      building block of a common language runtime application

        //2.AssemblyName ------------ Identifies an assembly ith a unique name
        //3.ConstructorInfo	 -------- Describes a class constructor and gives access to the metadata
        //4.MethodInfo ------------- Describes the class method and gives access to its metadata
        //5. ParameterInfo --------- Describes the parameters of a method and gives access to its metadata

        // this are some of commonly type reflections
        // 
        //Example 1:
        //In the code given below, we load the type t as a string using the typeof method.
        //Then we apply reflection on t to find any information about string class, like its name, fullname,
        //namespace, and basetype.
        static void Main(string[] args)
        {
            Type t = typeof(string);
            Console.WriteLine(" name : {0}", t.Name);
            Console.WriteLine(" namespace :{0}", t.Namespace);
            Console.WriteLine(" assembly: {0}", t.Assembly);
            Console.WriteLine("fullname : {0} ", t.FullName);

        }

        

        



    }
}
