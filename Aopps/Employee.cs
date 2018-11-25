using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aopps
{
    public class Employee
    {
        public int Pay;
        public int Bonus;

        public int GetSalaryOld(string empType)
        {
            if (empType == "Permanant")
            {
                Permanant p = new Permanant();
                Pay = p.GetPay();
                Bonus = p.GetBonous();
            }
            else if (empType == "Temporary")
            {
                Temporary t = new Temporary();
                Pay = t.GetPay();
                Bonus = t.GetBonous();
            }
            else if (empType == "Contractual")
            {
                Contractual c = new Contractual();
                Pay = c.GetPay();
                Bonus = c.GetBonous(); 
            }
            else if(empType=="SubCon")
            {
                SubCon s = new SubCon();
                Pay = s.GetPay();
                Bonus = s.GetBonous();
            }

            return Pay * Bonus;
        }

        public int GetSalary(string empType)
        {
            EmployeeManager em = new EmployeeManager();
            IEmployee obj = em.GetEmployeeType(empType);
            Pay = obj.GetPay();
            Bonus = obj.GetBonous();

            return Pay * Bonus;
        }
    }
}
