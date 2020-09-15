using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    class PassFailCourse
    {
        public string CourseName;
        public bool Grade;
        public PassFailCourse(string courseName, bool grade)
        {
            CourseName = courseName;
            Grade = grade;
        }

        public bool Passed() {
            return Grade;
        }
        
        //not req
        public string Name()
        {
            return CourseName;
        }
    }

    class GradedCourse
    {
        public string CourseName;
        public double Grade;

        public GradedCourse(string courseName, double grade) 
        {
            CourseName = courseName;
            Grade = grade;
        }

        public bool Passed() 
        {
            if (Grade >= 70)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        
        //not req
        public string Name()
        {
            return CourseName;
        }
    }

    class Degree
    {
        public PassFailCourse PFCourseA;
        public PassFailCourse PFCourseB;
        public GradedCourse GCourseA;
        public GradedCourse GCourseB;

        public Degree(PassFailCourse pfCourseA, PassFailCourse pfCourseB,
                      GradedCourse gCourseA, GradedCourse gCourseB)
        {
            PFCourseA = pfCourseA;
            PFCourseB = pfCourseB;
            GCourseA = gCourseA;
            GCourseB = gCourseB;    
        }

        public bool Passed() 
        {
            int numPassed = 0;
            if (PFCourseA.Passed() == true)
            {
                numPassed++;
            }
            else { }
            if (PFCourseB.Passed() == true)
            {
                numPassed++;
            }
            else { }
            if (GCourseA.Passed() == true)
            {
                numPassed++;
            }
            else { }
            if (GCourseB.Passed() == true)
            {
                numPassed++;
            }
            else { }

            if (numPassed >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //EXAMPLE 1
            PassFailCourse MastersCourse1 = new PassFailCourse("Masters Course 1", true);
            PassFailCourse MastersCourse2 = new PassFailCourse("Masters Course 2", false);
            GradedCourse MastersCourse3 = new GradedCourse("Masters Course 3", 86);
            GradedCourse MastersCourse4 = new GradedCourse("Masters Course 4", 63);

            Degree MastersDegree = new Degree(MastersCourse1, MastersCourse2, 
                                              MastersCourse3, MastersCourse4);

            Console.WriteLine(MastersCourse1.Name() + " Satified: " + MastersCourse1.Passed());
            Console.WriteLine(MastersCourse2.Name() + " Satified: " + MastersCourse2.Passed());
            Console.WriteLine(MastersCourse3.Name() + " Satified: " + MastersCourse3.Passed());
            Console.WriteLine(MastersCourse4.Name() + " Satified: " + MastersCourse4.Passed());
            Console.WriteLine();
            Console.WriteLine("Masters Degree Req Met: " + MastersDegree.Passed());

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            

            //EXAMPLE 2
            PassFailCourse BachelorCourse1 = new PassFailCourse("Bachelor Course 1", true);
            PassFailCourse BachelorCourse2 = new PassFailCourse("Bachelor Course 2", true);
            GradedCourse BachelorCourse3 = new GradedCourse("Bachelor Course 3", 97);
            GradedCourse BachelorCourse4 = new GradedCourse("Bachelor Course 4", 51);

            Degree BachelorDegree = new Degree(BachelorCourse1, BachelorCourse2,
                                               BachelorCourse3, BachelorCourse4);

            Console.WriteLine(BachelorCourse1.Name() + " Satified: " + BachelorCourse1.Passed());
            Console.WriteLine(BachelorCourse2.Name() + " Satified: " + BachelorCourse2.Passed());
            Console.WriteLine(BachelorCourse3.Name() + " Satified: " + BachelorCourse3.Passed());
            Console.WriteLine(BachelorCourse4.Name() + " Satified: " + BachelorCourse4.Passed());
            Console.WriteLine();
            Console.WriteLine("Bachelor Degree Req Met: " + BachelorDegree.Passed());


            Console.ReadKey();
        }
    }
}
