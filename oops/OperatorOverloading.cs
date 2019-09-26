﻿using oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class OperatorOverloading
    {
    }

    class Complex
    {
        private int x;
        private int y;
        public Complex()
        {

        }
        public Complex(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        //Binary Operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }

        //Unary operator
        public static Complex operator -(Complex c)
        {
            Complex temp = new Complex();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }
    }
    class MyClient
    {
        public static void BootUp()
        {
            Complex c1 = new Complex(10, 20);
            c1.ShowXY(); // displays 10 & 20  
            Complex c2 = new Complex(20, 30);
            c2.ShowXY(); // displays 20 & 30  
            Complex c3 = new Complex();
            c3 = c1 + c2;
            c3.ShowXY(); // dislplays 30 & 50  


            Complex c4 = new Complex(10, 20);
            c4.ShowXY(); // displays 10 & 20  
            Complex c5 = new Complex();
            c5.ShowXY(); // displays 0 & 0  
            c5 = -c4;
            c5.ShowXY(); // diapls -10 & -20  
        }
    }  
}
