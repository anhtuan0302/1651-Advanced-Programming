using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex2___Person
{
    public class Person
    {
        private string _name;
        private string _address;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Person()
        {
            this.Name = "Unknow";
            this.Address = "Unknow";
        }

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public override string ToString()
        {
            return "Person [" + Name + " (" + Address + ")]";
        }
    }
}
