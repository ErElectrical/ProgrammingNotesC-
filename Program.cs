using System;

namespace DelegatesPurpose
{
    public class Program
    {
        /// <summary>
        /// Delegates are type safe function pointer
        /// Delegtaes signature should Match with The Method signature to which it is pointing.
        /// Delegates also have instance same as class and we have to pass the Method name to the constructor of delegates.
        /// </summary>
        /// <param name="message"></param>
        public delegate void DelegateCall(string message);

        public delegate void MulticaseDelegateCall();

        public delegate void SecondMulticastDelegate();
        static void Main()
        {
            DelegateCall Dl = new DelegateCall(HelloTeam);
            Dl("Hello To Delegates");

            //First way to declare Multicast delegate
            MulticaseDelegateCall Del1, Del2, Del3, Del4;
            Del1 = new MulticaseDelegateCall(SampleMethodOne);
            Del2 = new MulticaseDelegateCall(SampleMethodTwo);
            Del3 = new MulticaseDelegateCall(SampleMethodThree);
            Del4 = Del1 + Del2 + Del3;
            Del4();

            //unregister of Method from delegate
            //we unregister sampleMethodTwo

            Del4 = Del4 - Del2;

            Console.WriteLine("After unregister SampleMethodTwo ");

            Del4();

            //second way to declare Multicast delegates

            SecondMulticastDelegate MulDel = new SecondMulticastDelegate(SampleMethodOne);
            MulDel += SampleMethodTwo;
            MulDel += SampleMethodThree;
            MulDel();

            Console.WriteLine("After unregister SampleMethodTwo ");
            MulDel -= SampleMethodTwo;
            MulDel();


        }

        public static void HelloTeam(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method One call");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method Two Call ");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three call ");
        }

    }
}
