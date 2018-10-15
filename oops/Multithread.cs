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
            if (_CallBack == null)
                _CallBack(5);

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
        public static int Total = 0;
        public static object _lock = new object();

        public ThreadAppDemo()
        {
        }

        public void RunDemo()
        {
            //SetFinalCallBackDelegate del1 = new SetFinalCallBackDelegate(this.FinalFunctionCall);
            //Multithread m1 = new Multithread(15, del1);
            //m1.TwoThreadedMethod();

            ThreadJoinAndISAlive();

            InterlockedAndLockObject();

        }

        private static void InterlockedAndLockObject()
        {
            //First approach and problem : Single threaded.
            //TotalSum();
            //TotalSum();
            //TotalSum();

            //Console.WriteLine("Total Sum : "+Total);

            Thread t1 = new Thread(ThreadAppDemo.TotalSum);
            Thread t2 = new Thread(ThreadAppDemo.TotalSum);
            Thread t3 = new Thread(ThreadAppDemo.TotalSum);

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Total Sum : " + Total);
        }

        public static void TotalSum()
        {
            //better performance over lock
            for (int i = 0; i < 100; i++)
            {
                Interlocked.Increment(ref Total);
            }

            //for (int i = 0; i < 100; i++)
            //{
            //    lock(_lock)
            //    {
            //        Total++;
            //    } 
            //}
        }

        private static void ThreadJoinAndISAlive()
        {
            Console.WriteLine("Main Program started");

            Thread t1 = new Thread(ThreadAppDemo.PrintMethod1);
            t1.Start();

            Thread t2 = new Thread(ThreadAppDemo.PrintMethod2);
            t2.Start();

            if (t1.Join(1000))
            {
                Console.WriteLine("Thread t1 Ended");
            }
            else
            {
                Console.WriteLine("Thread t1 has not completed yet.");
            }

            if (t1.IsAlive)
            {
                Console.WriteLine("Thread t1 is still processing");
            }
            else
            {
                Console.WriteLine("Thread t1 is done processing. So it is finished its job");
            }

            t2.Join();
            Console.WriteLine("Thread t2 Ended");

            Console.WriteLine("Main Program ended");
        }

        public static void PrintMethod1()
        {
            Console.WriteLine("T1 PrintMethod1 Started");
            Thread.Sleep(2000);
            Console.WriteLine("T1 PrintMethod1 is about to return");

        }

        public static void PrintMethod2()
        {
            Console.WriteLine("T2 PrintMethod2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("T2 PrintMethod1 is about to return");
        }


        public void FinalFunctionCall(int i)
        {
            Console.WriteLine("Final Function Call");
        }

        public void DoSomething(int id, int sleeptime)
        {
            Console.WriteLine("Started working on dosomething task with id : "+id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Completed working on dosomething task with id : " + id);
        }

        public void DoSomethingMore(int id, int sleeptime)
        {
            Console.WriteLine("Started working on dosomethingmore++ task with id : " + id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Completed working on dosomethingmore++ task with id : " + id);
        }

        public void InvokeTaskFactory()
        {
            var t1 = Task.Factory.StartNew(() => DoSomething(1, 1500)).ContinueWith((prevTask) => DoSomethingMore(1, 2000));
            var t2 = Task.Factory.StartNew(() => DoSomething(2, 3000)).ContinueWith((prevTask) => DoSomethingMore(2, 1000));
            var t3 = Task.Factory.StartNew(() => DoSomething(3, 1000)).ContinueWith((prevTask) => DoSomethingMore(3, 3000));

            var taskList = new List<Task> { t1, t2, t3};

            //Until all finished. it will wait.
            Task.WaitAll(taskList.ToArray());
        }
    }
}
