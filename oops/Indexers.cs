using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    /// <summary>
    /// Indexer allows classes to be used in more intuitive manner. 
    /// C# introduces a new concept known as Indexers which are used for treating an object as an array. 
    /// The indexers are usually known as smart arrays in C#. They are not essential part of object-oriented programming.
    /// Indexer Concept is object act as an array.
    /// Indexer an object to be indexed in the same way as an array.
    /// Indexer modifier can be private, public, protected or internal.
    /// The return type can be any valid C# types.
    /// Indexers in C# must have at least one parameter. Else the compiler will generate a compilation error.
    /// </summary>
    public class Indexers
    {
        public void IndexerCaller()
        {
            Customer c1 = new Customer();
            //Without indexers
            Console.WriteLine(c1.GetAddress(100000).Mobile);
            Console.WriteLine(c1.GetAddress("Pune").Mobile);


            //Main close of Indexers to simplify your code interface
            Console.WriteLine(c1[300000].Mobile);
            Console.WriteLine(c1["Banglore"].Mobile);
        }
    }

    public class Customer
    {
        private List<Address> Addresses = new List<Address>();

        public Customer()
        {
            Addresses.Add(new Address
            {
                PinCode = 100000,
                StreetName = "Mumbai",
                Mobile = "9921999219"
            });

            Addresses.Add(new Address
            {
                PinCode = 200000,
                StreetName = "Pune",
                Mobile = "9922099220"
            });

            Addresses.Add(new Address
            {
                PinCode = 300000,
                StreetName = "Calcutta",
                Mobile = "9922199221"
            });

            Addresses.Add(new Address
            {
                PinCode = 400000,
                StreetName = "Banglore",
                Mobile = "9922299222"
            });
        }

        public Address this[int pinCode]
        {
            get
            {
                foreach (Address o in Addresses)
                {
                    if (o.PinCode == pinCode)
                    {
                        return o;
                    }
                }

                return null;
            }
        }

        public Address this[string streetName]
        {
            get
            {
                foreach (Address o in Addresses)
                {
                    if (o.StreetName == streetName)
                    {
                        return o;
                    }
                }

                return null;
            }
        }

        public Address GetAddress(int pincode)
        {
            foreach(Address o in Addresses)
            {
                if(o.PinCode == pincode)
                {
                    return o;
                }
            }

            return null;
        }

        public Address GetAddress(string streetName)
        {
            foreach (Address o in Addresses)
            {
                if (o.StreetName == streetName)
                {
                    return o;
                }
            }

            return null;
        }
    }

    public class Address
    {
        public int PinCode { get; set; }

        public string StreetName { get; set; }

        public string Mobile { get; set; }
    }
}
