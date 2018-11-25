using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
    class SubCon  : IEmployee
    {
        public int GetBonous()
        {
            return 3;
        }

        public int GetPay()
        {
            return 10;
        }
    }
}
