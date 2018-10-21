using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class YieldKyeword
    {
        public static List<int> MyList = new List<int>();

        public static void Fillvalues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }

        public static void PrintList()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Fillvalues();
            foreach(int val in Filter2())
            {
                Console.WriteLine(val);
            }
            watch.Stop();
            //Filter1()  3834 time ticks
            //Filter2()  6780 time ticks
            Console.WriteLine("Time Elapsed : "+watch.ElapsedTicks.ToString());
        }


        //First approach
        public static IEnumerable<int> Filter1()
        {
            List<int> temp = new List<int>();
            foreach(int val in MyList)
            {
                if(val>3)
                {
                    temp.Add(val);
                }
            }

            return temp;
        }

        //Second approach
        /// <summary>
        /// Yield remembers the state. So this is StateFull approach.
        /// How it executes : caller1 called Filter2. Checks values it stops at value
        /// 4 and return the value for print then again Filter2 called then it remebers its 
        /// state that last time it was on 4 value then for next iteration it takes 5 value
        /// and send it if condition is true.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> Filter2()
        {
            foreach (int val in MyList)
            {
                if (val > 3)
                {
                   yield return val;
                }
            }
        }


    }
}
