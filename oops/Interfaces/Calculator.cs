using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Interfaces
{
    /// <summary>
    /// Interfaces : Explicit Contracts, enforces rules, decoupling from caller and callee. Impact Analysis. Abstraction - Show only what is necessary.
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

            IBasicMathComponentsExtended m3 = new MathComponents();
            
            

        }
    }
}
