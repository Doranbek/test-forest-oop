using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MovableObject : AliveObject
    {
        public MovableObject(byte x, byte y) : base(x, y)
        {}

        public void Move(byte x, byte y)
        {
            if (Alive) Location = (x, y);
        }
    }
}
