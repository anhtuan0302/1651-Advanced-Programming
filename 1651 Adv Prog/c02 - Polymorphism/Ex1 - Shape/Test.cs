using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Polymorphism.Ex1___Shape
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Shape s1 = new Rectangle("red", 4, 5);
            Console.WriteLine(s1);
            Console.WriteLine("Area is " + s1.GetArea());

            Console.WriteLine();

            Shape s2 = new Triangle("blue", 4, 5);
            Console.WriteLine(s2);
            Console.WriteLine("Area is " + s2.GetArea());

        }
    }
}
