using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    public interface IMakeCoffee
    {
        public bool CheckingIngredientAvailbility();
       public  string CoffeeMkaing(int suggerperspone, int CoffeePack);
    }
}
