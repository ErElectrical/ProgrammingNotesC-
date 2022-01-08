using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public  class EventHandle
    {

        //This program simply adds two numbers.
        //Only condition is if the sum of number is odd it fires an event that print a message using delegates.

        public delegate void dg_OddNumber(); //Declared Delegate     
        public event dg_OddNumber ev_OddNumber; //Declared Events

        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(); //Raised Event
            }
        }
        //Delegates calls this method when event raised.  
        public static void EventMessage()
        {
            Console.WriteLine("********Event Executed : This is Odd Number**********");
        }


    }
}
