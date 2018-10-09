using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oops
{
    public class Multithread
    {
        public void TwoThreadedMethod()
        {
            //PrintNumbers();
            //PrintNumbers();

            Thread t0 = new Thread(PrintNumbers);
            Thread t1 = new Thread(delegate () { PrintNumbers(); });
            Thread t2 = new Thread(new ThreadStart(PrintNumbers));
            Thread t3 = new Thread(()=> PrintNumbers());

            t0.Start();
            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void PrintNumbers()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------");
        }
    }
}
