using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lettersandnumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            //overhaead
            char[] Cap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] low = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            List<char> CapLetters = Cap.ToList();
            List<char> letters = low.ToList();
            List<int> fib = new List<int>();

            int n1 = 0, n2 = 1, n3, i;
            for (i = 2; i < letters.Count(); ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                fib.Add(n3);
                n1 = n2;
                n2 = n3;
            }
            fib.Add(1);
            fib.Add(0);
            fib.Sort();

            //this is where the overhad stops
            Console.WriteLine("enter a word");
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char x in input) {

                if (CapLetters.Contains(x) || letters.Contains(x)) {

                    //CAPLETTERS
                    if (CapLetters.IndexOf(x) == -1)
                    { //checking if x is not in the list
                        //do nothing 
                    }
                    else {
                        sum = sum + fib[CapLetters.IndexOf(x)];
                    }

                    //lowercase
                    if (letters.IndexOf(x) == -1)
                    { //checking if x is not in the list
                        //do nothing 
                    }
                    else
                    {
                        sum = sum + fib[letters.IndexOf(x)];
                    }
                }
            }

            Console.WriteLine("fibonacci sum ==> " + sum);

            Console.ReadKey();
        }
    }
}
