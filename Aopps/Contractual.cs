using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
    public  class Contractual : IEmployee
    {
        public int GetPay()
        {
            return 15;
        }
        public int GetBonous()
        {
            return 3;
        }
    }
}
