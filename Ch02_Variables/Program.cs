using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMeters = 1.88; // declaring and initialising local variable (local and private non-capital)
            WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}.");

            int defaultValueOfInt = default(int); //0

            int? ICouldBweNull = null; //allow value type to be null with '?'

            //declaring the sieze of the array
            string[] names = new string[4];
            //storing items at index positions
            names[0] = "Kiwi";
            names[1] = "Synek";
            names[2] = "Kiwi";
            names[3] = "Synek";
            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }

            int population = 66000000;
            double weight = 1.88;
            decimal price = 4.99M;
            string fruit = "Appleas"; // string uses double quotes
            char letter = 'Z'; // chars single

            // string interpolation
            Write($"The population of the UK is {population}. ");
            WriteLine($"The population of the UK is {population:N0}."); //N0 - commas for thausands
            WriteLine($"{weight}kg of {fruit} costs {price:C}."); //C - currency depending on current thread

            // getting input
            Write("Type your name and press enter: ");
            string name = ReadLine();
            Write("Type your age and press enter: ");
            string age = ReadLine();
            WriteLine($"Hello {name}, you look good for {age}.");


        }
    }
}
