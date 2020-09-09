using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentgrades1nooop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            List<double> grade = new List<double>();

            bool running = true;

            while (running == true) {

                Console.WriteLine("1 ==> enter names");
                Console.WriteLine("2 ==> display average");
                Console.WriteLine("3 ==> quit");
                string input = Console.ReadLine();


                //option 1
                if(input == "1") {

                    Console.WriteLine("enter the number of students");
                    int num = int.Parse(Console.ReadLine());

                    for (int i = 0; i < num; i++) {
                        Console.WriteLine("enter student: ");
                        name.Add(Console.ReadLine());

                        Console.WriteLine("enter student grade: ");
                        grade.Add(double.Parse(Console.ReadLine()));

                    }      
                }

                //option 2
                if (input == "2") {
                    Console.WriteLine("Average: " + grade.Average());
                
                }

                //option 3
                if(input == "3") {
                    running = false;
                    break;
                    
                    }




            
            
            
            
            
            }


            Console.ReadKey();

        }
    }
}
