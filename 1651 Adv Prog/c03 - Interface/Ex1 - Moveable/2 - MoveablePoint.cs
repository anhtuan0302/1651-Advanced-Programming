using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c03___Interface.Ex1___Moveable
{
    public class MoveablePoint : IMoveable
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public MoveablePoint(): this(0, 0)
        {
        }

        public MoveablePoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "MoveablePoint [X = " + X + ", Y = " + Y + "]";
        }

        public void MoveUp()
        {
            Y++;
        }

        public void MoveDown()
        {
            Y--;
        }

        public void MoveLeft()
        {
            X--;
        }

        public void MoveRight()
        {
            X++;
        }
    }
}
