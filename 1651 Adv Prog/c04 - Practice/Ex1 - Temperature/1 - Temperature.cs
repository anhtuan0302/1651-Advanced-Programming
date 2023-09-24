using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c04___Practice.Ex1___Temperature
{
    public class Temperature
    {
        private double _ftemp;

        public double FTemp
        {
            get { return _ftemp; }
            set { _ftemp = value; }
        }

        public Temperature(): this(0)
        {
        }

        public Temperature(double ftemp)
        {
            this.FTemp = ftemp;
        }

        public double getCelcius()
        {
            return (double) 5/9 * (FTemp - 32);
        }

        public double getKelvin()
        {
            return getCelcius() + 273;
        }

    }
}
