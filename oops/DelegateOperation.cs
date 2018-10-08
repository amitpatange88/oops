using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public static class TestDelegate
    {
        public delegate int DelegateObject(int a, int b);

        public static void CallDelegate()
        {
            DelegateObject adddel = new DelegateObject(DelegateDemo.Add);
            DelegateObject subdel = new DelegateObject(DelegateDemo.Sub);
            int c = adddel.Invoke(3, 4);
            int d = subdel.Invoke(6, 3);
            Console.WriteLine("C: " + c);
            Console.WriteLine("D: " + d);

            //multicase delegate
            DelegateObject del;
            DelegateObject del1 = new DelegateObject(DelegateDemo.Add);
            DelegateObject del2 = new DelegateObject(DelegateDemo.Sub);

            del = del1;
            del += del2;

            Console.WriteLine("del: " + del(8, 3));
            Console.ReadLine();
        }
    }

    public class DelegateDemo
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
