using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Analytics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> decimals = new List<double>();
            decimals.Add(0.5);
            decimals.Add(0.75);
            decimals.Add(0.758);
            decimals.Add(0.35);
            decimals.Add(0.25);
            decimals.Add(0.24);
            decimals.Add(0.8133);
            decimals.Add(0.723);
            decimals.Add(0.411236);
            decimals.Add(0.00045645);

            foreach (double x in decimals)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Average: " + decimals.Average());
            Console.WriteLine("Minimum: " + decimals.Min());
            Console.WriteLine("Maximum: " + decimals.Max());

            Console.ReadKey();

        }
    }
}
