using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex2___Animal
{
    public class Fish: Animal , IPet
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;  }
        }

        public Fish(): this("Unknow")
        {
        }

        public Fish(string name)
        {
            this.Name = name;
        }

        public void Play()
        {
            Console.WriteLine("Fish is playing");
        }

        public override void Eat()
        {
            Console.WriteLine("Fish is eating");
        }

        public override void Walk()
        {
            Console.WriteLine("Fish can't walk");
        }
    }
}
