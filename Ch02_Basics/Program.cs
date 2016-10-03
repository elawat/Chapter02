using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Ch02_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.SqlClient.SqlConnection connection;
            System.Xml.XmlReader reader;
            System.Xml.Linq.XElement element;
            System.Net.Http.HttpClient client;

            // loop through assemblies that this application references
            foreach (var r in Assembly.GetExecutingAssembly()
                .GetReferencedAssemblies())
            {
                //load assembly so we can read its details
                var a = Assembly.Load(r.FullName);
                // declare and set a variable to count the total number of methods
                int methodCount = 0;
                // loop though all the types in assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                // output the count of types and their methods
                Console.WriteLine($"{a.DefinedTypes.Count()} types with {methodCount} methods in {r.Name} assembly.");
            }

        }
    }
}
