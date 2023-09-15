using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c01
{
    class Author
    {
        private string _name;
        private string _email;
        private char _gender;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public char Gender
        {
            get { return _gender; }
            private set { _gender = value; }
        }
        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            if (gender == 'm' || gender == 'f')
            {
                this.Gender = gender;
            }
        }
        public override string ToString()
        {
            return "Author [Name = " + Name + ", Email = " + Email + ", Gender = " + Gender + "]";
        }
    }
}
