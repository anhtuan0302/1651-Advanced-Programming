using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c01
{
    class Circle
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle()
        {
            Radius = 0.0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return "Cricle [Radius = " + Radius + "]";
        }
    }
}
