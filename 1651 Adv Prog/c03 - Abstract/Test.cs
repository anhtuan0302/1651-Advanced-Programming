using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Abstract
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Shape s1 = new Rectangle(1, 2, "red");
            Console.WriteLine(s1);
            Console.WriteLine("Area is " + s1.GetArea());

            Shape s2 = new Triangle(3, 4, "blue");
            Console.WriteLine(s2);
            Console.WriteLine("Area is " + s2.GetArea());

        }
    }
}
