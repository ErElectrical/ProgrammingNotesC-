using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public  class FakeStarbuckstore : IMakeCoffee

        //Fake objects actually have working implementations.
           //• The purpose of a fake is not to affect the behavior of the system under test, but rather
           //to simplify the implementation of the test (by removing unnecessary dependencies)
            //• Fake classes can change the behavior based on input.
          //• Fake class functions can return different output for different inputs unlike that of stub.
    {
        public bool CheckingIngredientAvailbility()
        {
            return true;
        }

        public string CoffeeMkaing(int suggerperspone, int CoffeePack)
        {
            return " your order is recieved";
        }

    }
}
