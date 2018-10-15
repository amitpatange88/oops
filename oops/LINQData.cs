using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class LINQData
    {
        public void RunLinq()
        {
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees("PALI_e1", "Parvez Ali", "FOOTBALL", 1));
            employees.Add(new Employees("AALI_e2", "Ashik Ali", "FOOTBALL", 1));
            employees.Add(new Employees("AALI_e3", "Aftab Ali", "CHESS", 2));
            employees.Add(new Employees("AALI_e4", "Arif Ali", "CRICKET", 3));

            Console.WriteLine("\nPlease Enter Your Choice");
            string Choice = Console.ReadLine();

            foreach (Employees e in employees)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }

    public class Employees
    {
        public string employeeID;
        public string Name;
        public string eventHeld;
        public int eventId;

        public Employees(string eID, string eName, string eEvents, int eId)
        {
            this.employeeID = eID;
            this.Name = eName;
            this.eventHeld = eEvents;
            this.eventId = eId;
        }
    }
}
