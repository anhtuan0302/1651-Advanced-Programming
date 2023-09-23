using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex2___Animal
{
    public class Cat: Animal , IPet
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;  }
        }

        public Cat(): this("Unknow")
        {
        }

        public Cat(string name) : base(4)
        {
            this.Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void Play()
        {
            Console.WriteLine("Cat is playing");
        }
    }
}
