using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
    public class EmployeeManager
    {
        public Dictionary<string, IEmployee> Emps = new Dictionary<string, IEmployee>();

        public EmployeeManager()
        {
            Emps.Add("Permanant", new Permanant());
            Emps.Add("Temporary", new Temporary());
            Emps.Add("Contractual", new Contractual());
            Emps.Add("SubCon", new SubCon());
        }


        public IEmployee GetEmployeeType(string empType)
        {
            return Emps[empType];
        }

        public IEmployee GetEmployeeTypeOld(string empType)
        {
            IEmployee obj;

            if (empType == "Permanant")
            {
                 obj = new Permanant();
            }
            else if (empType == "Temporary")
            {
                 obj = new Temporary();
            }
            else// if (empType == "Contractual")
            {
                 obj = new Contractual();
            }

            return obj;

        }

    }
}
