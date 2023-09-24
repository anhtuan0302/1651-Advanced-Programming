using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c04___Practice.Ex1___Temperature
{
    public class Test
    {
        public static void Main(string[] args)
        {
            double ftemp;
            while (true)
            {
                Console.Write("Please enter Fahrenheit value: ");
                ftemp = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                if (ftemp == 0)
                    break;

                else
                {
                    Temperature temp = new Temperature(ftemp);
                    Console.WriteLine("Fahrenheit: " + temp.FTemp);
                    Console.WriteLine("Celcius: " + temp.getCelcius());
                    Console.WriteLine("Kelvin: " + temp.getKelvin());

                    Console.WriteLine();
                    Console.WriteLine("*********************************");
                    Console.WriteLine();
                }
            }
        }
    }
}
