using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_DATABASE
{
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
                if (grade >= 90) { A++; }
                if (grade >= 80 && grade < 90) { B++; }
                if (grade >= 70 && grade < 80) { C++; }
                if (grade >= 60 && grade < 70) { D++; }
                if (grade < 60) { F++; }
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
            string students = "";
            foreach (Student person in Students)
            {
                students = students + person.getName() + ", ";

            }
            return students;
        }

    }
}
