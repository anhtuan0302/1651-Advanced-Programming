using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex3___Shape
{
    public class Test
    {
        public static void Main(string[] args)
        {
            //Test Shape
            Shape s1 = new Shape();
            Console.WriteLine(s1);
            Shape s2 = new Shape("blue", false);
            Console.WriteLine(s2);

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            //Test Circle
            Circle c1 = new Circle();
            Console.WriteLine(c1);
            Console.WriteLine("Area is " + c1.GetArea());
            Console.WriteLine("Perimeter is " + c1.GetPerimeter());
            Console.WriteLine();
            Circle c2 = new Circle(1.1);
            Console.WriteLine(c2);
            Console.WriteLine("Area is " + c2.GetArea());
            Console.WriteLine("Perimeter is " + c2.GetPerimeter());
            Console.WriteLine();
            Circle c3 = new Circle(2.2, "yellow", true);
            Console.WriteLine(c3);
            Console.WriteLine("Area is " + c3.GetArea());
            Console.WriteLine("Perimeter is " + c3.GetPerimeter());

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            //Test Rectangle
            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1);
            Console.WriteLine("Area is " + r1.GetArea());
            Console.WriteLine("Perimeter is " + r1.GetPerimeter());
            Console.WriteLine();
            Rectangle r2 = new Rectangle(1.1, 2.2);
            Console.WriteLine(r2);
            Console.WriteLine("Area is " + r2.GetArea());
            Console.WriteLine("Perimeter is " + r2.GetPerimeter());
            Console.WriteLine();
            Rectangle r3 = new Rectangle(3.3, 4.4, "orange", true);
            Console.WriteLine(r3);
            Console.WriteLine("Area is " + r3.GetArea());
            Console.WriteLine("Perimeter is " + r3.GetPerimeter());

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            //Test Square
            Square s = new Square(2);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
            Console.WriteLine();
            s.Side = 3;
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
            Console.WriteLine();
            s.Length = 4;
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
            Console.WriteLine();
            s.Width = 5;
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
        }
    }
}
