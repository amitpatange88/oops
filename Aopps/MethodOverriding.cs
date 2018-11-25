using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps.MethodOverriding
{
    public class Car
    {
         public virtual int GetAirbags()
        {
            Console.WriteLine("Car");
            return 2;
        }


    }

    public class Bmw:Car
    {
        public override int GetAirbags()
        {
            Console.WriteLine("Bmw");
            return 4;
        }
    }

    public class Audi:Car
    {
        public new int GetAirbags()
        {
            Console.WriteLine("Audi");
            return 5;
        }
    }

}
