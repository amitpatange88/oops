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

        public static void Calcualte()
        {
            OriginalClass rate = new OriginalClass();
            int price = rate.TotalPrice(4, 1000);
            int discountedPrice = rate.FinalPriceAfterDiscount(4, 1000);
            Console.WriteLine("Price Without Discount :" + price);
            Console.WriteLine("Price With discount :" + discountedPrice);
        }
    }

    //When we needed to add a new function to an existing class type without 
    //changing the original source of code and without the use of inheritance.
    //We want to provide flat 100 rupees discount to the final price.
    public class OriginalClass
    {
        public int TotalPrice(int productCount, int Cost)
        {
            return productCount * Cost;
        }
    }

    public static class DiscountedClass
    {
        public static int FinalPriceAfterDiscount(this OriginalClass obj, int productCount, int finalPrice)
        {
            // flat 100 rupees discount  
            return productCount * finalPrice - 100;
        }
    }
}
