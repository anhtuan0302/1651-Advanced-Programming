using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c01
{
    class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _salary;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            private set { _lastName = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public int AnnualSalary()
        {
            return Salary * 12;
        }

        public int RaiseSalary(int percent)
        {
            return Salary * percent / 100 + AnnualSalary();
        }

        public override string ToString()
        {
            return "Employee [ID = " + Id + ", FullName = " + FullName() + ", Salary = " + Salary + "]";
        }
    }
}
