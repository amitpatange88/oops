using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
    public class Temporary : IEmployee
    {
        public int GetPay()
        {
            return 30;
        }
        public int GetBonous()
        {
            return 5;
        }
    }
}
