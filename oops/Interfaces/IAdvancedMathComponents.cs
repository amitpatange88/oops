using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Interfaces
{
    public interface IAdvancedMathComponents : IBasicMathComponents
    {
        void Log();

        int Radius(int circum);

        int Sin(double opp, double hypo);

        int Cos(double opp, double hypo);
    }
}
