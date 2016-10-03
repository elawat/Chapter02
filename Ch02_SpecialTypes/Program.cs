using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02_SpecialTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a doule in an object
            object name = "Kiwi"; // storing a syring in an object
            //int length1 = name.length; // gives compile error
            int length2 = ((string)name).Length; // cast to access members, boxing/unboxing
                                                 // avoid using obejct

            //in dynaimic object the value stores can have its members invoced without an explicit cast
            // avoid too
            dynamic anotherName = "Synek"; // string stored in dynamic object
            int length = anotherName.length; // compiles bit may throw exception on runtime
        
        }
    }
}
