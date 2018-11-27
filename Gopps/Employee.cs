using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gopps
{
    public class Employee
    {
       
    }

    public class BaseClass
    {
        protected internal int myValue = 0;
    }

    class TestAccess
    {
        void Access()
        {
            BaseClass baseObject = new BaseClass();
            baseObject.myValue = 5;
        }
    }


}
