using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{

    // now our genric class is able to take any dataType parameter
    //example defines a generic class, GFG, which uses a generic type parameter ‘T’.
    //In the Main() method, two instances of GFG have been created by replacing ‘T’ with ‘string’ and ‘float’ data types.
    //These objects are used to store ‘string’ and ‘float’ values respectively.
    //The GFG class ensures type safety by accepting the required type in its constructor.
    public class Genrics<T>
    {
        // field varible
        public T data;

        public T value
        {
            // accessor 
            // get to return the value
            //set to pass this value to data varible
            get
            {
                return data;
            }
            set
            {
                this.data= value;
            }
        }
    }
}
