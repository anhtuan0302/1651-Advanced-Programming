using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Polymorphism.Ex2___Circle
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle(1.1);
            Console.WriteLine(c1);
            Console.WriteLine("Area is " + c1.GetArea());

            Console.WriteLine();

            Cylinder c2 = new Cylinder(2.2, 3.3);
            Console.WriteLine(c2);
            Console.WriteLine("Area is " + c2.GetArea());
            Console.WriteLine("Volume is " + c2.GetVolume());

            Console.WriteLine();
        }
    }
}
