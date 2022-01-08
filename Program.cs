using System;
using static Delegates.DelegateExample;
using static Delegates.MulticastDelegates;

namespace Delegates
{
    public class Program
    {
        //A delegate is an object which refers to a method or you can say it is a reference type variable
        //that can hold a reference to the methods.

        //Delegates in C# are similar to the function pointer in C/C++.
        //It provides a way which tells which method is to be called when an event is triggered. 
        // For example, if you click on a Button on a form(Windows Form application),
        // the program would call a specific method.
        // In simple words, it is a type that represents references to methods with a particular parameter list
        // and return type and then calls the method in a program for execution when it is needed.

        //important points about delegates
        //Provides a good way to encapsulate the methods.
        //Delegates are the library class in System namespace.
        //These are the type-safe pointer of any method.
        // Delegates are mainly used in implementing the call-back methods and events.
        // Delegates can be chained together as two or more methods can be called on a single event.
        //It doesn’t care about the class of the object that it references.
        //Delegates can also be used in “anonymous methods” invocation.

        //Delegate type can be declared using the delegate keyword. Once a delegate is declared, delegate instance will refer and call those methods whose return type and parameter-list matches with the delegate declaration.
       // Syntax: 

      //[modifier] delegate [return_type][delegate_name] ([parameter_list]);

        static void Main(String[] args)
        {
            Console.WriteLine("welcome To delegate tutorial");

            DelegateExample obj = new DelegateExample();

            // creating object of delegate, name as "del_obj1"
            // for method "sum" and "del_obj2" for method "subtract" &
            // pass the parameter as the two methods by class object "obj"
            // instantiating the delegates

            addnum del_obj1 = new addnum(obj.Addnum);
            multiple del_obj2 = new multiple(obj.Mul);

            del_obj1(100, 200);
            del_obj2(10, 20, 40);
            // we can pass the parameter using Invoke keyword also

            // uses of multicast delegate

            // create a object of class
            MulticastDelegates multicast = new MulticastDelegates();

            Areafunc del_obj = new Areafunc(multicast.area);

            // now do multicast
            del_obj += multicast.perimeter;

            del_obj.Invoke(100, 200);

            // remove a method as according to our requirement
            del_obj -= multicast.area;

            del_obj.Invoke(20, 40);
                
                



        }


    }
}
