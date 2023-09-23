using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex2___Animal
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Fish d = new Fish();
            Cat c = new Cat("Fluffy");
            Animal a = new Fish();
            Animal e = new Spider();
            IPet p = new Cat();

            d.Name = "Fish 1";
            Console.WriteLine("Fish's name: " + d.Name);
            d.Eat();
            d.Play();
            d.Walk();

            Console.WriteLine();

            Console.WriteLine("Cat's name: " + c.Name);
            c.Eat();
            c.Play();
            c.Walk();

            Console.WriteLine();

            ((Fish)a).Name = "Fish 2";
            Console.WriteLine("Fish's name: " + ((Fish)a).Name);
            a.Eat();
            a.Walk();

            Console.WriteLine();

            e.Eat();
            e.Walk();

            Console.WriteLine();

            p.Name = "Cat 2";
            Console.WriteLine("Cat's name: " + p.Name);
            p.Play();
        }
    }
}
