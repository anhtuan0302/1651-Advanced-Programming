using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex2___Animal
{
    public class Spider: Animal
    {
        public Spider(): base(8)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Spider is eating");
        }
    }
}
