using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class TupleUsage
    {
        public void CreateTuple()
        {
            //firstname middlename lastname
            string fullName = "Amit B Patange";

            var response = ParseFullName(fullName);

            Console.WriteLine("First Name : "+response.Item1);
            Console.WriteLine("First Name : " + response.Item2);
            Console.WriteLine("Last Name : " + response.Item3);
            Console.ReadLine();
        }


        /// <summary>
        /// Tuple created variables into one logical unit. Reduce the overhead of extra code and variables to define, use.
        /// bad practice to use Item1, Item2.... so Tuples are problematic to recorgnise which data means to what.
        /// SO we introduce Ananonymous Types will resolve this problem
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static Tuple<string, string, string> ParseFullName(string fullName)
        {
            string[] arr = new string[3];
            arr = fullName.Split(' ');

            return Tuple.Create<string, string, string>(arr[0], arr[1], arr[2]);

        }
    }

    public class AnonymousTypesUsage
    {
        public void CreateAnonymous()
        {
            //firstname middlename lastname
            string fullName = "Rohan P Vadge";

            var response = Cast(ParseFullName(fullName), new { FirstName = "", MiddleName = "", LastName = ""});

            Console.WriteLine("First Name : " + response.FirstName);
            Console.WriteLine("First Name : " + response.MiddleName);
            Console.WriteLine("Last Name : " + response.LastName);
            Console.ReadLine();
        }


        /// <summary>
        /// SO we introduce Ananonymous Types will resolve this problem
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static object ParseFullName(string fullName)
        {
            string[] arr = new string[3];
            arr = fullName.Split(' ');

            return new { FirstName = arr[0], MiddleName = arr[1], LastName = arr[2] };
        }

        static T Cast<T>(Object obj, T Type)
        {
            return (T)obj;
        }
    }
}
