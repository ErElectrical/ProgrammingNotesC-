using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{

    // this class contains our real logic 
    public  class Starbucksstore
    {
        // creating the constructor of interface 
        private readonly IMakeCoffee Service;

        // initialising the constructor

        public Starbucksstore(IMakeCoffee Service)
        {
            this.Service = Service;
        }

        public string OrderCoffee(int Sugarpersupone,int CoffeeCount)
        {
            if (Service.CheckingIngredientAvailbility())
            {
                return Service.CoffeeMkaing(Sugarpersupone, CoffeeCount);
            }
            else
            {
                return " sorry ! coffee is not available";
            }
        }
    }
}
