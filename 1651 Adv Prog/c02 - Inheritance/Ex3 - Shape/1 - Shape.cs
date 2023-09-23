using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex3___Shape
{
    public class Shape
    {
        private string _color = "red";
        private bool _filled = true;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public bool Filled
        {
            get { return _filled; }
            set { _filled = value; }
        }

        public Shape() : this ("green", true)
        {
        }

        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + Color + " and " + (Filled ? "filled" : "not filled");
        }
    }
}
