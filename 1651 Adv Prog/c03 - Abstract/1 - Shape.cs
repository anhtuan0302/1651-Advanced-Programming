using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Abstract
{
    public abstract class Shape
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Shape(): this("green")
        {
        }

        public Shape (string color)
        {
            this.Color = color;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return "Shape [Color = " + Color + "]";
        }
    }
}
