using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static oops.ThreadAppDemo;

namespace oops
{
    public class Multithread
    {
        public int _Target = 0;
        public SetFinalCallBackDelegate _CallBack;

        public Multithread() { }

        public Multithread(int i, SetFinalCallBackDelegate callback)
        {
            _Target = i;
            _CallBack = callback;
        }

        public void TwoThreadedMethod()
        {
            //PrintNumbers();
            //PrintNumbers();

            Thread t1 = new Thread(delegate () { PrintNumbers(); });
            Thread t2 = new Thread(new ThreadStart(PrintNumbers));
            Thread t3 = new Thread(()=> PrintNumbers());
            //Thread t4 = new Thread(PrintNumbers); // call is ambiguous because we have 2 methods with same name but diff signature so this ambiguous.

            t1.Start();
            t2.Start();

            ParameterizedThreadStart p1 = new ParameterizedThreadStart(PrintNumbers);
            Thread t5 = new Thread(p1);
            object target = 5;
            t5.Start(target);

            Console.ReadKey();
        }

        public void PrintNumbers()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------");
        }

        /// <summary>
        /// We couldn't place int as parameter in this method because 
        /// ParameterizedThreadStart delegate accepts object as parameter for its function.
        /// </summary>
        /// <param name="target"></param>
        public void PrintNumbers(object target)
        {
            //unboxing we have performed here.
            int number = (int)target;

            //or we can perform this also withour unboxing.
            int.TryParse(target.ToString(), out int num);


            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------");
        }
    }

    public class ThreadAppDemo
    {
        public delegate void SetFinalCallBackDelegate(int i);

        public ThreadAppDemo()
        {
        }

        public void RunDemo()
        {
            SetFinalCallBackDelegate del1 = new SetFinalCallBackDelegate(this.FinalFunctionCall);
            Multithread m1 = new Multithread(15, del1);
            m1.TwoThreadedMethod();
        }


        public void FinalFunctionCall(int i)
        {
            Console.WriteLine("Final Function Call");
        }
    }
        

}
