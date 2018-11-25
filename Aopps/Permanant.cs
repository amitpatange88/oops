using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
   public class Permanant : IEmployee
    {
        public int GetPay()
        {
            return 50;
        }
        public int GetBonous()
        {
            return 10;
        }
    }
}
