using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Print
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Names = new List<string>();

            Names.Add("Allen");
            Names.Add("Kevin");
            Names.Add("Moe");
            Names.Add("Jack");
            Names.Add("Glen");
            Names.Add("Evan");
            Names.Add("Danyelle");
            Names.Add("Trish");
            Names.Add("Jerry");
            Names.Add("Jared");

            Names.Sort();
            Names.Reverse();

            foreach (string x in Names)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
