using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex2___Person
{
    public class Student: Person
    {
        private int _numCourses = 0;
        private List<string> _courses = new List<string>();
        private List<int> _grades = new List<int>();

        public int NumCourses
        {
            get { return _numCourses; }
            set { _numCourses = value; }
        }

        public List<string> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public List<int> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public Student(): base()
        {
        }

        public Student(string name, string address): base(name, address)
        {
        }

        public void AddCourseGrade(string course, int grade)
        {
            Courses.Add(course);
            Grades.Add(grade);
            NumCourses++;
        }

        public void PrintGrades()
        {
            for (int i = 0; i < NumCourses; i++)
            {
                Console.WriteLine(Courses[i] + ": " + Grades[i]);
            }
        }

        public double GetAverageGrade()
        {
            int sum = 0;
            for (int i = 0; i < NumCourses; i++)
            {
                sum += Grades[i];
            }
            return (double) sum / NumCourses;
        }

        public override string ToString()
        {
            return "Student [" + Name + " (" + Address + ")]";
        }
    }
}
