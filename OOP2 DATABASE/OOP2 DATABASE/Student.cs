using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_DATABASE
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
            return Grade;
        }

    }
}
