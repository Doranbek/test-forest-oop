using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AliveObject : ObjectWithLocation
    {
        public bool Alive { get; private set; } = true;
        public int Age { get; private set; } = 0;

        public AliveObject(byte x, byte y) : base(x, y)
        {}

        public void Grow() => Age += 1;

        public void Die() => Alive = false;
    }
}
