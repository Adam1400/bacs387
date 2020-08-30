using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_from_List
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

            bool running = true;

            while (running == true)
            {
                Console.WriteLine();
                Console.WriteLine("Type a name to remove it from the list:");
                string input = Console.ReadLine();

                foreach (string x in Names)
                {
                    if (x == input)
                    {
                        Names.Remove(x);
                        running = false;
                        break;
                    }
                }
                Console.WriteLine("TRY AGAIN (Case sensitive)");
            }

            Console.WriteLine();
            Console.WriteLine("New List:");
            foreach (string x in Names)
            {
                Console.WriteLine(x);
            }



            Console.ReadKey();
        }
    }
}
