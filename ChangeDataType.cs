using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class ChangeDataType
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        
        public double Add(double a, double b)
        {
            double sum = a + b ;
            return sum;
        }
    }
}
