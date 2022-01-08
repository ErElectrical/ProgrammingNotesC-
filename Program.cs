using System;

namespace EventHandler
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to tutorial of Events Handler");

            //WHAT IS EVENTS?
            // Events are nothing just a user action.For example
            //When you click with the mouse – It is mouse click events.
            //When you press any key in keyboard – It is KeyPress events
            //when you refresh your webpage – It is page load events
            //When you move mouse cursor – It is mouse hover events etc.

            //HOW EVENTS WORK WITH DELEGATES?

            // Delegates are used to reference a method.
            // An Event is associated with Event Handler using Delegates.
            // When an Event raise, it sends a signal to delegates and delegates executes the right function.

            // WHAT IS PUBLISHER - SUBSCRIBER MODEL?

            // There are two parts in any event handling program.
            // One part is Publisher that contains definition of events and delegates and another part is Subscriber
            // that accepts the event and provides an event handler.

            //IMPORTANT FACT ABOUT EVENTS
            //An Event is created using event keyword.
            //An Event has no return type and it is always void.
            //All events are based on delegates.
            //All the published events must have a listening object.
            //All Events should be defined starting with “On” keyword.

            //you must know the sequential steps to manipulate events.

            //Step 1: Define a Delegate
            //Step 2: Define an Event with same name of Delegates.
            //Step 3: Define an Event Handler that respond when event raised.
            //Step 4: You must have method ready for delegates

            EventHandle cvent = new EventHandle();

            // event gets binds with delegetes

            cvent.ev_OddNumber += new EventHandle.dg_OddNumber(EventHandle.EventMessage);

            cvent.Add();
            Console.ReadLine();

            // the Process will occur like this.

           // Delegate Created
           //public delegate void dg_OddNumber();

           // Event Created
          //public event dg_OddNumber ev_OddNumber;
          //ev_OddNumber() event gets executed if the odd number is found.
        // In the AddTwoNumbers class there is a function void Add() that adds two numbers.
        // If the sum of the number is Odd it raised an ev_OddNumber event.
        // In the main function this ev_OddNumber event handler calls the delegates

         //a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
         //Then finally delegate executes the function.
        //static void EventMessage()
        //{
        //    Console.WriteLine("********Event Executed : This is Odd Number**********");
        //}




    }
    }
}