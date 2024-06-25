using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oswald
{
    internal class Program
    {


        public class BaseClass
        {
            // Public member is accessible from anywhere
            public int publicField = 1;

            // Private member is accessible only within the class
            private int privateField = 2;

            // Protected member is accessible within the class and by derived class instances
            protected int protectedField = 3;

            // Internal member is accessible within the same assembly
            internal int internalField = 4;

            // Protected internal member is accessible within the same assembly and by derived class instances
            protected internal int protectedInternalField = 5;

            // Private protected member is accessible within the class and derived class instances within the same assembly
            private protected int privateProtectedField = 6;

            public void ShowAccess()
            {
                Console.WriteLine("Access within BaseClass:");
                Console.WriteLine("Public Field: " + publicField);
                Console.WriteLine("Private Field: " + privateField);
                Console.WriteLine("Protected Field: " + protectedField);
                Console.WriteLine("Internal Field: " + internalField);
                Console.WriteLine("Protected Internal Field: " + protectedInternalField);
                Console.WriteLine("Private Protected Field: " + privateProtectedField);
            }
        }

        public class DerivedClass : BaseClass
        {
            public void ShowDerivedAccess()
            {
                Console.WriteLine("Access within DerivedClass:");
                Console.WriteLine("Public Field: " + publicField);
                // Console.WriteLine("Private Field: " + privateField); // Not accessible
                Console.WriteLine("Protected Field: " + protectedField);
                Console.WriteLine("Internal Field: " + internalField);
                Console.WriteLine("Protected Internal Field: " + protectedInternalField);
                Console.WriteLine("Private Protected Field: " + privateProtectedField);
            }
        }

        public class Program789
        {
            static void Main()
            {
                BaseClass baseObj = new BaseClass();
                DerivedClass derivedObj = new DerivedClass();

                // Accessing fields from BaseClass instance
                Console.WriteLine("Accessing from Program (BaseClass instance):");
                Console.WriteLine("Public Field: " + baseObj.publicField);
                // Console.WriteLine("Private Field: " + baseObj.privateField); // Not accessible
                // Console.WriteLine("Protected Field: " + baseObj.protectedField); // Not accessible
                Console.WriteLine("Internal Field: " + baseObj.internalField);
                Console.WriteLine("Protected Internal Field: " + baseObj.protectedInternalField);
                // Console.WriteLine("Private Protected Field: " + baseObj.privateProtectedField); // Not accessible

                // Accessing fields from DerivedClass instance
                Console.WriteLine("Accessing from Program (DerivedClass instance):");
                Console.WriteLine("Public Field: " + derivedObj.publicField);
                // Console.WriteLine("Private Field: " + derivedObj.privateField); // Not accessible
                //Console.WriteLine("Protected Field: " + derivedObj.protectedField);
                Console.WriteLine("Internal Field: " + derivedObj.internalField);
                Console.WriteLine("Protected Internal Field: " + derivedObj.protectedInternalField);
               // Console.WriteLine("Private Protected Field: " + derivedObj.privateProtectedField);

                baseObj.ShowAccess();
                derivedObj.ShowDerivedAccess();
                Console.ReadLine();
            }
        }

    }
}
   


