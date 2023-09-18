using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Polymorphism.Ex2___Circle
{
    public class Circle
    {
        private double _radius;
        
        public double Radius
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public Circle()
        {
            this.Radius = 0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public virtual double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle {Radius = " + Radius + "}";
        }
    }
}
