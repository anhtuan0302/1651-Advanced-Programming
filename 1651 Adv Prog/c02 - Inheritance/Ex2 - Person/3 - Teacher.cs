using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex2___Person
{
    public class Teacher: Person
    {
        private int _numCourses = 0;
        private List<string> _courses = new List<string>();

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

        public Teacher() : base()
        {
        }

        public Teacher(string name, string address) : base(name, address)
        {
        }

        public bool AddCourse(string course)
        {
            for (int i = 0; i < NumCourses; i++)
            {
                if (Courses[i] == course)
                {
                    return false;
                }
            }
            Courses.Add(course);
            NumCourses++;
            return true;
        }

        public bool RemoveCourse(string course)
        {
            for (int i = 0; i < NumCourses; i++)
            {
                if (Courses[i] == course)
                {
                    Courses.RemoveAt(i);
                    NumCourses--;
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Teacher [" + Name + " (" + Address + ")]";
        }

    }
}
