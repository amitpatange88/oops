using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Interfaces
{
    /// <summary>
    /// This is where we need to or we can implement multiple interfaces to class.
    /// Once existing interface goes live on production so better not to touch the old interface for modification.
    /// </summary>
    public class MathComponents : IAdvancedMathComponents, IBasicMathComponentsExtended
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Cos(double opp, double hypo)
        {
            throw new NotImplementedException();
        }

        public int Div(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Log()
        {
            throw new NotImplementedException();
        }

        public int Mul(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Radius(int circum)
        {
            throw new NotImplementedException();
        }

        public int Sin(double opp, double hypo)
        {
            throw new NotImplementedException();
        }

        public int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
