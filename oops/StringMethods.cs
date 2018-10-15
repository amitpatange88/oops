using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public static class StringMethods
    {
        /// <summary>
        /// Extension Methods
        /// </summary>
        public static bool IsStartWithLetterM(this string s)
        {
            return s.StartsWith("m");
        }
    }
}
