using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running == true)
            {
                Console.WriteLine("Selct with coorisponding number:");
                Console.WriteLine("1 => About this developer");
                Console.WriteLine("2 => Quit");

                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine("How's it going? My name is Allen and I'm a senior" +
                        " going into my last semester at UNC. My major " +
                        "is SE and I love to program both in school and " +
                        "in my free time!  Aside from programming I also " +
                        "enjoy playing the Pokemon trading card game at a " +
                        "competitive level.  In the past I have traveled " +
                        "across the country participating in tournaments." +
                        " If you ever need advice on programming (or Pokemon cards)" +
                        " please hit me up! Looking forward to my last semester" +
                        " with you all! ");
                        Console.WriteLine();
                    }
                    if (input == 2)
                    {
                        running = false;
                    }

                    else
                    {
                        Console.WriteLine("Enter a number (1 or 2)");
                    }
                }
                catch { Console.WriteLine("Enter a number (1 or 2)"); }
            }
            Console.ReadKey();

        }
    }
}
