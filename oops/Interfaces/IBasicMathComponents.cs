using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Interfaces
{
    /// <summary>
    /// Once the interace is goes live or on production. 
    /// Not a good practice to change the existing interface. 
    /// So create new interfaces for newly methods
    /// </summary>
    public interface IBasicMathComponents 
    {
        int Add(int a, int b);

        int Sub(int a, int b);
    }

    public interface IBasicMathComponentsExtended
    {
        int Mul(int a, int b);

        int Div(int a, int b);
    }
}
