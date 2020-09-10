using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_1
{
    class Student 
    {
        public string Name;
        public double Grade;

        //establish a student
        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        //return student name
        public string getName() 
        {
            return Name; 
        }

        //return student grade
        public double getGrade()
        {
            return Grade; ;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List <Student> Students = new List<Student>();

            Students.Add(new Student("Allen Adams", 100.0));
            Students.Add(new Student("Glen Adams", 95.1));
            Students.Add(new Student("Kelly Adams", 10.3));

            foreach (Student person in Students) 
            {
                Console.WriteLine(person.getName() + ", " + person.getGrade());

            }
            Console.WriteLine();

            Console.WriteLine("Average: "+ Students.Select(person => person.getGrade()).Average());

            Console.ReadKey();
        }
    }
}
