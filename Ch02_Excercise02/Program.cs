using System;

namespace Ch02_Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = new String('-', 80);
            string[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};
            int[] sizes = { sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal) };
            dynamic[] mins = { sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue };
            dynamic[] maxs = { sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue };
            Console.WriteLine(result);
            Console.WriteLine("{0,-10} {1,-5} {2,10} {3,10}", "Type", "Byte(s) of memory", "Min", "Max");
            Console.WriteLine(result);
            for (int ctr = 0; ctr < types.Length; ctr++)
                Console.WriteLine("{0,-10} {1,-5} {2,10} {3,10}", types[ctr], sizes[ctr], mins[ctr], maxs[ctr]);
            Console.WriteLine(result);
        }
    }
}
