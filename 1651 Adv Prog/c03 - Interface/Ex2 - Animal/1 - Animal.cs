using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex2___Animal
{
    public abstract class Animal
    {
        private int _legs;

        public int Legs
        {
            get { return _legs; }
            private set { _legs = value; }
        }

        public Animal(): this(0)
        {
        }

        protected Animal(int legs)
        {
            this.Legs = legs;
        }

        public virtual void Walk()
        {
            Console.WriteLine("This animal walk by " + Legs + " legs");
        }

        public abstract void Eat();
    }
}
