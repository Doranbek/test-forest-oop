using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mountain : ObjectWithLocation
    {
        public int Height { get; private set; }

        public Mountain( byte x, byte y, int height) : base(x, y)
        {
            Height = height;
        }
    }
}

