using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex1___Moveable
{
    public class Test
    {
        public static void Main(string[] args)
        {
            IMoveable m1 = new MoveablePoint(5, 6);
            Console.WriteLine(m1);
            m1.MoveLeft();
            Console.WriteLine(m1);
            m1.MoveDown();
            Console.WriteLine(m1);
            m1.MoveRight();
            Console.WriteLine(m1);
            m1.MoveUp();
            Console.WriteLine(m1);
        }
    }
}
