using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{
    public class GenricExample
    {

        //Just as a method can take one argument, generics can take various parameters.
        //One argument can be passed as a familiar type and other as a generic type

        public void display<TypeOfValue>(string msg,TypeOfValue value)
        {
            Console.WriteLine("{0} : {1} ",msg,value);
        }
    }
}
