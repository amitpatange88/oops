﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gopps
{
    public class Employee
    {
        public struct CoOrds
        {
            public int x, y;

            //parameter less consruct from struct
            //public CoOrds()
            //{

            //}

            public CoOrds(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
    }

    public class BaseClass
    {
        protected internal int myValue = 0;
    }

    class TestAccess
    {
        void Access()
        {
            BaseClass baseObject = new BaseClass();
            baseObject.myValue = 5;
        }
    }

    // Assembly1.cs  
    // Compile with: /target:library  
    public class Parent
    {
        //c# 7.2 contains this update
        //private protected int myValue = 0;
    }

    public class Child : BaseClass
    {
        void Access()
        {
            Parent baseObject = new Parent();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 5;  

            // OK, accessed through the current derived class instance
            myValue = 5;
        }
    }
}
