using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
    class MethodOverloading
    {
        public void Add(int a , int b)
        {
            int Add = a + b;
            Console.WriteLine("Two numbers addition {0} ",Add);
            
        }

        public void Add(int a, int b, double c)
        {
            double x = a + b + c;
            Console.WriteLine("Three numbers addition {0}", x);
            
        }
        public void Add(string a, string b)
        {
            string Add = a + b;
            Console.WriteLine("Two Strings addition {0} ", Add);

        }

        public void Calculate()
        {
            Add(2, 3);
            Add(2, 3, 4.5);
            Add("Amit", "Patange");
        }
        
        
    }

}
