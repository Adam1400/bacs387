using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
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

    class Course
    {
        public string courseName, courseId;
        public List<Student> Students = new List<Student>();

        //establish a course
        public Course(string name, string id, List<Student> students)
        {
            courseName = name;
            courseId = id;
            Students = students;
        }

        //makes life easier
        public List<double> getGradesList() 
        {
            List<double> grades = new List<double>();
            foreach (Student person in Students)
            {
                grades.Add(person.getGrade());
            }

            return grades;
        }

        //return average grade
        public double getAverageGrade()
        {

            return getGradesList().Average();
        }

        //return min
        public double getMinGrade()
        {
            return getGradesList().Min();
        }

        //return max
        public double getMaxGrade()
        {
            return getGradesList().Max();
        }

        //return % of a,b,c etc
        public double getPercentGrades(string LetterGrade)
        {
            double A = 0, B = 0, C = 0, D = 0, F = 0;
            foreach (double grade in getGradesList())
            {
                if (grade >= 90){ A++; }
                if (grade >= 80 && grade < 90){ B++; }
                if (grade >= 70 && grade < 80){ C++; }
                if (grade >= 60 && grade < 70){ D++; }
                if (grade < 60){ F++; }
            }

            if (LetterGrade == "A" || LetterGrade == "a") { return 100 * (A / getGradesList().Count()); }
            if (LetterGrade == "B" || LetterGrade == "b") { return 100 * (B / getGradesList().Count()); }
            if (LetterGrade == "C" || LetterGrade == "c") { return 100 * (C / getGradesList().Count()); }
            if (LetterGrade == "D" || LetterGrade == "d") { return 100 * (D / getGradesList().Count()); }
            if (LetterGrade == "F" || LetterGrade == "f") { return 100 * (F / getGradesList().Count()); }
            else { return 0; }

        }

        //Allows for better queries (not req)
        public string getCourseName()
        {
            return courseName;
        }

        public string getCourseId()
        {
            return courseId;
        }

        public string getStudentList() 
        {
            string students ="";
            foreach (Student person in Students)
            {
                students = students + person.getName() +", ";
                
            }
            return students;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //students in course
            //course 1
            List<Student> bacsStudents = new List<Student>();

            bacsStudents.Add(new Student("Allen Adams", 100.0));
            bacsStudents.Add(new Student("Glen Adams", 95.1));
            bacsStudents.Add(new Student("Kelly Adams", 10.3));

            //course 2
            List<Student> csStudents = new List<Student>();

            csStudents.Add(new Student("Allen Adams", 99.0));
            csStudents.Add(new Student("JC Sharp", 95.1));
            csStudents.Add(new Student("Jared Butler", 90.3));


            //List of courses
            List<Course> Courses = new List<Course>();

            Courses.Add(new Course("Object Oriented", "bacs387", bacsStudents));
            Courses.Add(new Course("Software Development", "cs350", csStudents));


            //display info about each course
            foreach (Course course in Courses)
            {

                Console.WriteLine("Couese Name: " + course.getCourseName());
                Console.WriteLine("Couese ID: " + course.getCourseId());
                Console.WriteLine("Students: " + course.getStudentList());
                Console.WriteLine();

                Console.WriteLine("Average: " + course.getAverageGrade());
                Console.WriteLine("Min Grade: " + course.getMinGrade());
                Console.WriteLine("Max Grade: " + course.getMaxGrade());
                Console.WriteLine("Percentage of A's: " + course.getPercentGrades("A") + "%");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
