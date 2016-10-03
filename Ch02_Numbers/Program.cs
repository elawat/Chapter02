using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue} to {int.MaxValue}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue} to {double.MaxValue}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue} to {decimal.MaxValue}.");
        }
    }
}
