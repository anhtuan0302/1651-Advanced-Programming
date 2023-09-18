using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex2___Person
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("Tan Ah Teck", "1 Happy Ave");
            s1.AddCourseGrade("IM101", 97);
            s1.AddCourseGrade("IM102", 68);
            Console.WriteLine(s1);
            s1.PrintGrades();
            Console.WriteLine("Average is " + s1.GetAverageGrade());

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            Teacher t1 = new Teacher("Paul Tan", "8 sunset way");
            Console.WriteLine(t1);
            String[] courses = { "IM101", "IM102", "IM101" };
            foreach (String course in courses)
            {
                if (t1.AddCourse(course))
                {
                    Console.WriteLine(course + " added.");
                }
                else
                {
                    Console.WriteLine(course + " cannot be added.");
                }
            }

            foreach (String course in courses)
            {
                if (t1.RemoveCourse(course))
                {
                    Console.WriteLine(course + " removed.");
                }
                else
                {
                    Console.WriteLine(course + " cannot be removed.");
                }
            }
        }
    }
}
