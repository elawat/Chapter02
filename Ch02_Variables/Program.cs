using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMeters = 1.88; // declaring and initialising local variable (local and private non-capital)
            Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}.");
        }
    }
}
