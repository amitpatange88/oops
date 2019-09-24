using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class A
    {
        //protected access modifier
        protected int x = 123;
    }

    
    class B : A
    {
        static void Start()
        {
            var a = new A();
            var b = new B();

            // Error CS1540, because x can only be accessed by
            // classes derived from A.
            //a.x = 10; 

            // OK, because this class derives from A.
            b.x = 10;
        }
    }

    class AccessibilityDomain
    {
    }

    //class by default private
    class Emp
    {
        public int EmpId = 0;
        public string EmpName = "Emp";
    }

    class Emp1 : Emp
    {
        //be default private
        int Emp1Id = 1;
        string Emp1Name = "Emp1";
    }

    public class Company
    {
        public void CreateEmpObj()
        {
            Emp1 e1 = new Emp1();
            
            
        }
    }


    public class T1
    {
        public static int publicInt;
        internal static int internalInt;
        private static int privateInt = 0;
        static T1()
        {
            // T1 can access public or internal members
            // in a public or private (or internal) nested class.
            M1.publicInt = 1;
            M1.internalInt = 2;
            M2.publicInt = 3;
            M2.internalInt = 4;

            // Cannot access the private member privateInt
            // in either class:
            // M1.privateInt = 2; //CS0122
        }

        public class M1
        {
            public static int publicInt;
            internal static int internalInt;
            private static int privateInt = 0;
        }

        private class M2
        {
            public static int publicInt = 0;
            internal static int internalInt = 0;
            private static int privateInt = 0;
        }
    }

    class MainClass
    {
        static void Entry()
        {
            // Access is unlimited.
            T1.publicInt = 1;

            // Accessible only in current assembly.
            T1.internalInt = 2;

            // Error CS0122: inaccessible outside T1.
            // T1.privateInt = 3;  

            // Access is unlimited.
            T1.M1.publicInt = 1;

            // Accessible only in current assembly.
            T1.M1.internalInt = 2;

            // Error CS0122: inaccessible outside M1.
            //    T1.M1.privateInt = 3; 

            // Error CS0122: inaccessible outside T1.
            //    T1.M2.publicInt = 1;

            // Error CS0122: inaccessible outside T1.
            //    T1.M2.internalInt = 2;

            // Error CS0122: inaccessible outside M2.
            //    T1.M2.privateInt = 3;

            // Keep the console open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }

    //Protected Internal
    // Assembly1.cs
    // Compile with: /target:library
    public class BaseClass
    {
        protected internal int myValue = 0;
    }

    class TestAccess
    {
        void Access()
        {
            var baseObject = new BaseClass();
            baseObject.myValue = 5;
        }
    }


    // Assembly2.cs
    // Compile with: /reference:Assembly1.dll
    class DerivedClass : BaseClass
    {
        static void FirstPoint()
        {
            var baseObject = new BaseClass();
            var derivedObject = new DerivedClass();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 10;

            // OK, because this class derives from BaseClass.
            derivedObject.myValue = 10;
        }
    }


    ////private protected
    //// Assembly1.cs  
    //// Compile with: /target:library  
    //public class BaseClass
    //{
    //    private protected int myValue = 0;
    //}

    //public class DerivedClass1 : BaseClass
    //{
    //    void Access()
    //    {
    //        var baseObject = new BaseClass();

    //        // Error CS1540, because myValue can only be accessed by
    //        // classes derived from BaseClass.
    //        // baseObject.myValue = 5;  

    //        // OK, accessed through the current derived class instance
    //        myValue = 5;
    //    }
    //}


    //Polymorphism Method Overriding

    public class X
    {
        public virtual void A()
        {
            Console.WriteLine("X.A");
        }
    }
    public class Y : X
    {
        public sealed override void A()
        {
            Console.WriteLine("Y.A");
        }
    }

    public class Z : Y
    {
        //A can not be further overriden because parent/base class i.e. class Y method A()
        //is being sealed so we can not override further
        public new void A()
        {
            Console.WriteLine("Z.A");
        }
    }
}
