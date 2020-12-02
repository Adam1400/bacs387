using System;
using System.Collections.Generic;
using System.Linq;



namespace OOP_Exercise_11
{
    class Program
    {
        //polymorphism
        class Course {

            //Encapsulation
            private string Id, Title;
            public List<Student> Students;
            public Course(string id, string title, List<Student> students) 
            {
                Id = id;
                Title = title;
                Students = students;
            }

            public string getCourseID() {
                return Id;
            }
            public string getCourseTitle()
            {
                return Title;
            }
            public void listStudents() {
                try
                {
                    string list = "";
                    foreach (Student x in Students)
                    {
                        list = list + x.getStudentId() + ", " + x.getStudentName() + "\n";
                    }

                    Console.WriteLine(list);
                }
                catch { Console.WriteLine("No Students"); }
            }
            public void AddStudent() {
                Console.WriteLine("Enter student information:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();
                Console.Write("First Name ==> ");
                string fname = Console.ReadLine();
                Console.Write("Last Name ==> ");
                string lname = Console.ReadLine();

                Students.Add(new Student(id, fname, lname));
                Console.WriteLine("Student Added to the Course!");
            }

            public void RemoveStudent() {
                listStudents();
                Console.WriteLine("Enter Student ID to remove:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();
                try
                {
                    foreach (Student x in Students)
                    {
                        if (x.getStudentId() == id)
                        {
                            Students.Remove(x);
                            Console.WriteLine("Student Removed Removed!");
                        }
                    }
                }
                catch { }
                Console.WriteLine();
            }

            public void UpdateGrade() {
                listStudents();
                Console.WriteLine("Enter Student ID to update grade:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();
                try
                {
                    foreach (Student x in Students)
                    {
                        if (x.getStudentId() == id)
                        {
                            x.setGrade();
                            Console.WriteLine("Grade Entred!");
                        }
                    }
                }
                catch { }
                Console.WriteLine();

            }

            public void GradeANA()
            {
                List<double> allGrades = new List<double>();
                double median;
                double a = 0 , b = 0, c = 0, d = 0, f = 0;
                foreach (Student x in Students) {
                    allGrades.Add(x.getGrade());
                }
                allGrades.Sort();

                try
                {
                    int half = allGrades.Count() / 2;
                    median = allGrades.ElementAt(half);
                }
                catch { 
                    int half = (allGrades.Count() / 2) + 1;
                    median = allGrades.ElementAt(half);
                }


                

                foreach (double x in allGrades)
                {
                    if (x >= 90)
                    {
                        a = a + 1;
                    }
                    if (x >= 80 && x < 90)
                    {
                        b = b + 1; ;
                    }
                    if (x >= 70 && x < 80)
                    {
                        c = c + 1; ;
                    }
                    if (x >= 60 && x < 70)
                    {
                        d = d + 1;
                    }
                    if (x < 60)
                    {
                        f = f + 1;
                    }
                }

                Console.WriteLine("Average: " + allGrades.Average());
                Console.WriteLine("Min: " + allGrades.Min());
                Console.WriteLine("Max: " + allGrades.Max());
                Console.WriteLine("Median: " + median);
                Console.WriteLine("% of A's: " + ((a / allGrades.Count()) * 100) + "%");
                Console.WriteLine("% of B's: " + ((b / allGrades.Count()) * 100) + "%");
                Console.WriteLine("% of C's: " + ((c / allGrades.Count()) * 100) + "%");
                Console.WriteLine("% of D's: " + ((d / allGrades.Count()) * 100) + "%");
                Console.WriteLine("% of F's: " + ((f / allGrades.Count()) * 100) + "%");





            }
        }

        //polymorphism
        class CourseList {
            public List<Course> Courses;
            public CourseList(List<Course> courses) {
                Courses = courses;
            }

            public void listCourses() {
                try
                {
                    string list = "";
                    foreach (Course x in Courses)
                    {
                        list = list + x.getCourseID() + ", " + x.getCourseTitle() + "\n";
                    }

                    Console.WriteLine(list);
                }
                catch { Console.WriteLine("No courses"); }
            }

            public void EnterCourse() {
                Console.WriteLine("Enter a new course:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();
                Console.Write("Title ==> ");
                string title = Console.ReadLine();
                
                Courses.Add(new Course(id, title, new List<Student>()));
                Console.WriteLine("Course Created!");
                Console.WriteLine();
            }

            public void RemoveCourse()
            {
                listCourses();
                Console.WriteLine("Choose a course to remove:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();

                try {
                    foreach (Course x in Courses) {
                        if (x.getCourseID() == id) {
                            Courses.Remove(x);
                            Console.WriteLine("Course Removed!");
                        }
                    }
                }
                catch { }
                Console.WriteLine();
            }

            public void EnterStudents() {
                listCourses();
                Console.WriteLine("Choose a course to add student:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();

                try
                {
                    foreach (Course x in Courses)
                    {
                        if (x.getCourseID() == id)
                        {
                            x.AddStudent();
                        }
                    }
                }
                catch { }
                Console.WriteLine();

            }

            public void RemoveStudents()
            {
                listCourses();
                Console.WriteLine("Choose a course to remove student:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();

                try
                {
                    foreach (Course x in Courses)
                    {
                        if (x.getCourseID() == id)
                        {
                            x.RemoveStudent();
                        }
                    }
                }
                catch { }
                Console.WriteLine();

            }

            public void EnterGrade()
            {
                listCourses();
                Console.WriteLine("Choose a course to enter grades:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();

                try
                {
                    foreach (Course x in Courses)
                    {
                        if (x.getCourseID() == id)
                        {
                            x.UpdateGrade();
                            
                            
                        }
                    }
                }
                catch { }
                Console.WriteLine();

            }

            public void GradeAnalytics() {
                listCourses();
                Console.WriteLine("Choose a course to see grade analytics:");
                Console.Write("ID ==> ");
                string id = Console.ReadLine();
                try
                {
                    foreach (Course x in Courses)
                    {
                        if (x.getCourseID() == id)
                        {
                            x.GradeANA();


                        }
                    }
                }
                catch { }
                Console.WriteLine();


            }

        }

        //polymorphism
        class Student {
            //Encapsulation
            private string Id, Fname, Lname;
            public double Grade = 0;
            public Student(string id, string fname, string lname) {
                Id = id;
                Fname = fname;
                Lname = lname;
            }
            public string getStudentId()
            {
                return Id;
            }
            public string getStudentName()
            {
                return Fname + " "+ Lname;
            }
            public void setGrade() {
                Console.WriteLine("Enter student grade %:");
                Console.Write("Grade ==> ");
                try
                {
                    Grade = Double.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Enter a numeric value next time"); }
            }

            public double getGrade() {
                return Grade;
            }

        }

        //Inheritance
        class PreSetStudent : Student {
            //encapsulation
            private string Id, Fname, Lname;
            
            //used for pre existing students who already have grades
            public PreSetStudent(string id, string fname, string lname, double grade) : base(id, fname, lname) 
            {
                Id = id;
                Fname = fname;
                Lname = lname;
                Grade = grade;

            }
        }









        static void Main(string[] args)
        {
            Student Allen = new PreSetStudent("1400", "Allen", "Adams", 100);
            Student Glen = new PreSetStudent("1500", "Glen", "Adams", 90);
            Student Kelly = new PreSetStudent("1600", "Kelly", "Adams", 50);

            List<Student> OOPstudents = new List<Student>();
            OOPstudents.Add(Allen);
            OOPstudents.Add(Glen);
            OOPstudents.Add(Kelly);

            Course BACS387 = new Course("BACS387","Object Oriented Programing", OOPstudents);
            
            
            List<Course> courseList = new List<Course>();
            courseList.Add(BACS387);

            

            CourseList UNCO = new CourseList(courseList);
            bool running = true;
            while (running ==  true) {
                Console.WriteLine("Select one of the options below:");
                Console.WriteLine("1 ==> Enter Course");
                Console.WriteLine("2 ==> Enter Students");
                Console.WriteLine("3 ==> Remove Students");
                Console.WriteLine("4 ==> Remove Course");
                Console.WriteLine("5 ==> Enter Student Grade");
                Console.WriteLine("6 ==> Grade Analytics");
                Console.WriteLine("7 ==> Quit");

                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1") { UNCO.EnterCourse(); }
                if (input == "2") { UNCO.EnterStudents(); }
                if (input == "3") { UNCO.RemoveStudents(); }
                if (input == "4") { UNCO.RemoveCourse();  }
                if (input == "5") { UNCO.EnterGrade();  }
                if (input == "6") { UNCO.GradeAnalytics();  }
                if (input == "7") { Console.WriteLine("Exiting..."); break; }






            }
            Console.ReadKey();
        }
    }
}
