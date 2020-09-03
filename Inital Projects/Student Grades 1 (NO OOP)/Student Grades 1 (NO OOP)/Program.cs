using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_1__NO_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<double> grades = new List<double>();

            bool running = true;

            while (running) {
                Console.WriteLine("Select one of the options below:");
                Console.WriteLine("1 ==> Enter Students");
                Console.WriteLine("2 ==> Display student grade average");
                Console.WriteLine("3 ==> Quit");
                string input = Console.ReadLine();

                if (input == "1") {
             
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter the number of students:");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        for (int i = 0; i < num; i++) {

                            Console.Write("Enter student " + (i +1 ) + "'s name: ");
                            names.Add(Console.ReadLine());
                            Console.Write("Enter student " + (i + 1) + "'s grade: ");
                            grades.Add(double.Parse(Console.ReadLine()));
                            Console.WriteLine();
                        }

                        Console.WriteLine("SUCCESS"); Console.WriteLine();
                    }
                    catch { 
                        Console.WriteLine("TRY AGAIN (list was cleared)"); 
                        Console.WriteLine();
                        names = new List<string>();
                        grades = new List<double>();
                    }
                }

                if (input == "2") {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Student Average: " + grades.Average());
                        Console.WriteLine();
                    }
                    catch {
                        Console.WriteLine();
                        Console.WriteLine("Enter Student Grades Fisrt");
                        Console.WriteLine();
                    }
                }

                if (input == "3") {
                    Console.WriteLine("EXITING....");
                    running = false;
                    break;
                }


            
            }

            Console.ReadKey();
        }
    }
}
