using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Polymorphism.Ex2___Circle
{
    public class Cylinder: Circle
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            private set { _height = value; }
        }

        public Cylinder(): base()
        {
            this.Height = 0;
        }

        public Cylinder(double radius, double height): base(radius)
        {
            this.Height = height;
        }

        public override double GetArea()
        {
            return (2 * Math.PI * Radius * Height) + (2 * base.GetArea());
        }

        public double GetVolume()
        {
            return base.GetArea() * Height;
        }

        public override string ToString()
        {
            return "Cylinder [Height = " + Height + ", " + base.ToString() + "]";
        }
    }
}
