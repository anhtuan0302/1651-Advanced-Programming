using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex1
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Point2D p2a = new Point2D(1, 2);
            Console.WriteLine(p2a);

            Point2D p2b = new Point2D();
            Console.WriteLine(p2b);

            p2a.X = 3;
            p2a.Y = 4;
            Console.WriteLine(p2a);
            Console.WriteLine("X is: " + p2a.X);
            Console.WriteLine("Y is: " + p2a.Y);

            Point3D p3a = new Point3D(11, 12, 13);
            Console.WriteLine(p3a);
            Point2D p3b = new Point3D();
            Console.WriteLine(p3b);

            p3a.X = 21;
            p3a.Y = 22;
            p3a.Z = 23;
            Console.WriteLine(p3a);
            Console.WriteLine("X is: " + p3a.X);
            Console.WriteLine("Y is: " + p3a.Y);
            Console.WriteLine("Z is: " + p3a.Z);
        }
    }
}
