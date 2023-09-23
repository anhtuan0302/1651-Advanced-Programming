using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c02___Inheritance.Ex1
{
    public class Point3D : Point2D
    {
        private int _z;
        
        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public Point3D(): base()
        {
            this.Z = 0;
        }

        public Point3D(int x, int y, int z): base(x, y)
        {
            this.Z = z;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }
    }
}
