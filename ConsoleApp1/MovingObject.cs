using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class MovingObject : LivingObject
    {
        public MovingObject(byte x, byte y) : base(x, y)
        {}

        public virtual void Move()
        {
            byte x = 0;
            byte y = 0;
            if (Alive) Location = (x, y);
        }
    }
}
