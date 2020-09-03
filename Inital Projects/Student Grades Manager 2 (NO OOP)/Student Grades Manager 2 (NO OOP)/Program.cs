using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager_2__NO_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Fnames = new List<string>();
            List<string> Lnames = new List<string>();
            List<string> Id = new List<string>();
            List<double> grades = new List<double>();


            bool running = true;

            while (running)
            {
                Console.WriteLine("Select one of the options below:");
                Console.WriteLine("1 ==> Enter Students");
                Console.WriteLine("2 ==> Enter Student Grade");
                Console.WriteLine("3 ==> Remove Students");
                Console.WriteLine("4 ==> Grade Analytics");
                Console.WriteLine("5 ==> Quit");
                string input = Console.ReadLine();

                if (input == "1")
                {

                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter the number of students:");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        for (int i = 0; i < num; i++)
                        {
                            jump:
                                Console.Write("Enter student " + (i + 1) + "'s ID: ");
                                string IdCheck = Console.ReadLine();
                                try
                                {
                                    foreach (string x in Id)
                                    {
                                        if (x == IdCheck)
                                        {
                                            Console.WriteLine("TRY AGAIN ==> Id already exists");
                                            Console.WriteLine();
                                        goto jump;
                                        }
                                    }
                                }
                                catch { }
                            
                            Id.Add(IdCheck);
                            Console.Write("Enter student " + (i + 1) + "'s First name: ");
                            Fnames.Add(Console.ReadLine());
                            Console.Write("Enter student " + (i + 1) + "'s Last name: ");
                            Lnames.Add(Console.ReadLine());
                            Console.WriteLine();
                        }

                        
                        for (int i = 0; i < Id.Count(); i++) {
                            grades.Add(0.0);
                        }
                        Console.WriteLine("SUCCESS"); Console.WriteLine();
                    }
                    catch
                    {
                        Console.WriteLine("TRY AGAIN (lists were cleared)");
                        Console.WriteLine();
                        Fnames = new List<string>();
                        Lnames = new List<string>();
                        Id = new List<string>();
                        grades = new List<double>();
                     
                    }
                }

                if (input == "2")
                {
                    try
                    {
                        Console.WriteLine();
                        for (int i = 0; i < Fnames.Count(); i++) {
                            Console.WriteLine(Id[i] + ", " + Fnames[i] + ", " + Lnames[i]);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Select Student by ID:");
                        string selectedId = Console.ReadLine();
                        Console.WriteLine("Enter Grade for "+ 
                            Fnames[Id.IndexOf(selectedId)] +" "+ 
                            Lnames[Id.IndexOf(selectedId)]);

                        double grade = double.Parse(Console.ReadLine());
                        grades[Id.IndexOf(selectedId)] = grade;
                        Console.WriteLine("SUCCESS"); Console.WriteLine();

                    }
                    catch
                    {
                        Console.WriteLine();
                        Console.WriteLine("TRY AGAIN");
                        Console.WriteLine();
                    }
                }

                if (input == "3") {
                    try
                    {
                        Console.WriteLine();
                        for (int i = 0; i < Fnames.Count(); i++)
                        {
                            Console.WriteLine(Id[i] + ", " + Fnames[i] + ", " + Lnames[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Select Student by ID:");
                        string selectedId = Console.ReadLine();
                        Console.WriteLine("Removed ==> " +
                                Fnames[Id.IndexOf(selectedId)] + " " +
                                Lnames[Id.IndexOf(selectedId)]);


                        Fnames.Remove(Fnames[Id.IndexOf(selectedId)]);
                        Lnames.Remove(Lnames[Id.IndexOf(selectedId)]);
                        grades.Remove(grades[Id.IndexOf(selectedId)]);
                        Id.Remove(Id[Id.IndexOf(selectedId)]);
                        Console.WriteLine();
                    }
                    catch {
                        Console.WriteLine();
                        Console.WriteLine("TRY AGAIN");
                        Console.WriteLine();
                    }
                }

                if(input == "4") {
                    try
                    {

                        Console.WriteLine();
                        Console.WriteLine("NOTE ==> Default Student grades are set to 0.0");
                        Console.WriteLine("Average: " + grades.Average());
                        Console.WriteLine("Min: " + grades.Min() + "  ==> " + // some sort of bug exists here when user                       
                            Fnames[grades.IndexOf(grades.Min())] + " " +      // attempts to add students more than once                      
                            Lnames[grades.IndexOf(grades.Min())]);            // there is an out of bounds error when                        
                        Console.WriteLine("Max: " + grades.Max() + "  ==> " + // calcing min and max in anylitics                       
                            Fnames[grades.IndexOf(grades.Max())] + " " +      // I have no idea why \_(-_-)_/                   
                            Lnames[grades.IndexOf(grades.Max())]);            // solution ==> prompt user to redo students

                        double A = 0, B = 0, C = 0, D = 0, F = 0;
                        foreach (double x in grades)
                        {
                            if (x >= 90)
                            {
                                A++;
                            }
                            if (x >= 80 && x < 90)
                            {
                                B++;
                            }
                            if (x >= 70 && x < 80)
                            {
                                C++;
                            }
                            if (x >= 60 && x < 70)
                            {
                                D++;
                            }
                            if (x < 60)
                            {
                                F++;
                            }
                        }

                        Console.WriteLine("% of A's ==> " + ((A / grades.Count()) * 100) + "%");
                        Console.WriteLine("% of B's ==> " + ((B / grades.Count()) * 100) + "%");
                        Console.WriteLine("% of C's ==> " + ((C / grades.Count()) * 100) + "%");
                        Console.WriteLine("% of D's ==> " + ((D / grades.Count()) * 100) + "%");
                        Console.WriteLine("% of F's ==> " + ((F / grades.Count()) * 100) + "%");
                        Console.WriteLine();
                    }
                    catch {
                        Console.WriteLine();
                        Console.WriteLine("TRY AGAIN (consider clearing students by selecting option 1 and typing 'clear')");
                        Console.WriteLine();
                    }
                }

                if (input == "5")
                {
                    Console.WriteLine("EXITING....");
                    running = false;
                    break;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
