using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{

    // It is our normal class
    public class Starbucks : IMakeCoffee
    {
       public  bool CheckingIngredientAvailbility()
        {
            return true;
        }

        string IMakeCoffee.CoffeeMkaing(int suggerperspone, int CoffeePack)
        {
            throw new NotImplementedException();
        }


    }

    // stub starbucks class

    //Stubs provide canned answers to calls made during the test regardless of the input.
       //• We can't control the behavior of the stub.
      //• The purpose of a stub is to get your system under test into a specific state.
    public class StubStarbucks : IMakeCoffee
    {
        public bool CheckingIngredientAvailbility()
        {
            return true;
        }

        public string CoffeeMkaing(int suggerperspone, int CoffeePack)
        {
            return " your order is recieved";

            // stub class always returns a canned answer
        }


    }

}
