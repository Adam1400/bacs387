using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_and_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //OVERHEAD
            //create letter index
            char[] Cap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] low = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            List<char> CapLetters = Cap.ToList();
            List<char> letters = low.ToList();


            //create fibonacci list
            List<int> fib = new List<int>();
            int n1 = 0, n2 = 1, n3, i;   
            for (i = 2; i < letters.Count(); ++i)    
            {
                n3 = n1 + n2;
                fib.Add(n3);
                n1 = n2;
                n2 = n3;
            }
            fib.Add(1);//missing a and b
            fib.Add(0);
            fib.Sort();//cleanup


            //CONSOLE APP
            Console.WriteLine("Enter a word and see its corrisponding fibonacci sum:");
            string word = Console.ReadLine();
            int sum = 0;

            foreach (char x in word) 
            {
                if(CapLetters.Contains(x) || letters.Contains(x))
                {
                    if (CapLetters.IndexOf(x) == -1)
                    {
                        //do nothing
                    }
                    else 
                    {
                        sum = sum + fib[CapLetters.IndexOf(x)];
                    }

                    if (letters.IndexOf(x) == -1)
                    {
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
