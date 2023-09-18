using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Polymorphism.Ex1___Shape
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

        public Triangle(): base()
        {
            this.Base = 0;
            this.Height = 0;
        }

        public Triangle(string color, int b, int h): base(color)
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
