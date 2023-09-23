using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Abstract
{
    public class Triangle: Shape
    {
        private int _base;
        private int _height;

        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Triangle(): this(1, 1)
        {
        }

        public Triangle(int b, int h): base()
        {
            this.Base = b;
            this.Height = h;
        }

        public Triangle(int b, int h, string color): base(color)
        {
            this.Base = b;
            this.Height = h;
        }

        public override double GetArea()
        {
            return (Base * Height) / 2;
        }

        public override string ToString()
        {
            return "Triangle [Base = " + Base + ", Height = " + Height + ", " +  base.ToString() + "]";
        }
    }
}
