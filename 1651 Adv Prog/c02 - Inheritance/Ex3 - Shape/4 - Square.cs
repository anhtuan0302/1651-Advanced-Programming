using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex3___Shape
{
    public class Square: Rectangle
    {
        public double Side
        {
            get { return Width; }
            set { Width = Length = value; }
        }

        public override double Width
        {
            get { return base.Width; }
            set { base.Width = base.Length = value; }
        }

        public override double Length
        {
            get { return base.Length; }
            set { base.Length = base.Width = value; }
        }

        public Square(): base()
        {
        }

        public Square(double side): base(side, side)
        {
        }

        public Square(double side, string color, bool filled): base(side, side, color, filled)
        {
        }

        public override string ToString()
        {
            return "A Square with side = " + Width + ", which is a subclass of " + base.ToString();
        }   
    }
}
