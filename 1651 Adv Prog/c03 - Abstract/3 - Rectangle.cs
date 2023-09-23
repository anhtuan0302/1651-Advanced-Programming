using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Abstract
{
    public class Rectangle: Shape
    {
        private int _length;
        private int _width;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(): this(1, 1)
        {
        }

        public Rectangle(int length, int width): base()
        {
            this.Length = length;
            this.Width = width;
        }

        public Rectangle(int length, int width, string color): base(color)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return "Rectangle [Length = " + Length + ", Width = " + Width + ", " + base.ToString() + "]";
        }
    }
}
