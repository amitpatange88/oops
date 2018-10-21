using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Interfaces
{
    /// <summary>
    /// Interfaces : Explicit Contracts, enforces rules, decoupling. 
    /// </summary>
    public class Calculator
    {
        public static void DoCalculation()
        {
            //Level of abstraction show only what is necessary to objects.
            IBasicMathComponents m1 = new MathComponents();
            m1.Add(2, 3);
            m1.Sub(8, 3);
            
            //Level of abstraction show only what is only necessary to objects.
            IAdvancedMathComponents m2 = new MathComponents();
            m2.Add(5, 3);
            m2.Sub(3, 6);
            m2.Log();
            m2.Sin(3.0, 5.0);

        }
    }
}
