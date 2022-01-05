using System;
using System.Collections.Generic;

namespace AdditionOfTwoNumber
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        //MSTest is Unit Testing framework for writing Unit test cases which
        // was developed by Microsoft.

        //Unit testing breaks the program down into the smallest bit of code,
        //usually function-level, and ensures that the function returns the
        // value one expects.By using a unit testing framework, the unit tests
        //become a separate entity which can then run automated tests on
        //the program as it is being built.

        //Unit Testing is based on the Arrange, Act, Assert methodology. You
         //arrange your initial considerations, act on those conditions with
          //your method under test, then assert something happened.

        //The entire goal for unit testing is to find failure atmocity.
        // which means that we have to find that case where our method fails

        // we dont suppose to connect with external data source.
        // it is because that our unit testing may effect that database on which other
        // developer are also working on that source.
        // it may effect there code.

        // Benefit of unit Testing 

        // safer refactoring
        // smaller,tighten, and decoupled code.
        // documentation of requirements.
        // continous integration.
        // valuee of tests increases over time

        public int  add(int num1,int num2)
        {
            int c = num1 + num2;
            return c;
        }
    }
}

