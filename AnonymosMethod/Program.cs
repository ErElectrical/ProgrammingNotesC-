using System;

namespace AnonymosMethod
{
    public class Program
    {

        public delegate void Petname(string pet);

        public delegate void SubjectName(string subject);
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Anonymos Method ");

            //An anonymous method is a method which doesn’t contain any name 
            //It is useful when the user wants to create an inline method
            //and also wants to pass parameter in the anonymous method like other methods.
            //An Anonymous method is defined using the delegate keyword and
            //the user can assign this method to a variable of the delegate type.

            // create an anonymos method with one parameter
            Petname p = delegate (string mypet)
              {
                  Console.WriteLine("your pet is : {0}", mypet);
              };
            p("cat");

            //This method is also known as inline delegate.
            //Using this method you can create a delegate object without writing separate methods.
            //This method can access variable present in the outer method.
            //Such type of variables is known as Outer variables.


            //outer varible
            string FavSubject = "Coding";

            SubjectName s = delegate (string sub)
             {
                 //able to use it inside our Anonymos function
                 Console.WriteLine("your favourite subject is : {0} ", FavSubject);
                 Console.WriteLine("your favourite Subjct is : {0} ", sub);
             };
            s("Math");

            // this anonymos method can also be passed to another method which use delegates as its parameter lets us see how

            //In anonymous methods, you are allowed to remove parameter-list, which means you can convert an anonymous method into a delegate.
            //The anonymous-method - block means the scope of the parameters in the anonymous method.
            //An anonymous method does not contain jump statements like goto, break, or continue.
            //An anonymous method does not access unsafe code.
            //An anonymous method does not access in, ref, and out parameter of the outer scope.
            //You can not use an anonymous method to the left side of the is operator.
            //You can also use an anonymous method as an event handler.


        }
    }
}
