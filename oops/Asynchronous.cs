using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Asynchronous
    {
        public string PrintAsync()
        {
            Task.Delay(5000);
            return "Hi! This is async method print";
        }

        public async void CallAsyncMethods()
        {
            Task<string> task = new Task<string>(PrintAsync);
            task.Start();
            Console.WriteLine("Task is running. Please wait...");
            string message = await task;
            Console.WriteLine("Task completed.");
            //or this is other way to write and run the task. with await task. combined and easy to write.
            //string message = await Task.Run(() => PrintAsync());

            Console.WriteLine(message);
        }
    }
}
