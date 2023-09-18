using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex3___Shape
{
    public class Rectangle: Shape
    {
        private double _width;
        private double _length;

        public virtual double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public virtual double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public Rectangle(): base()
        {
            this.Width = 1.0;
            this.Length = 1.0;
        }

        public Rectangle(double width, double length): base()
        {
            this.Width = width;
            this.Length = length;
        }

        public Rectangle(double width, double length, string color, bool filled): base(color, filled)
        {
            this.Width = width;
            this.Length = length;
        }

        public double GetArea()
        {
            return Width * Length;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Length);
        }

        public override string ToString()
        {
            return "A Rectangle with width = " + Width + " and length = " + Length + ", which is a subclass of " + base.ToString();
        }   
    }
}
