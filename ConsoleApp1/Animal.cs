using System;

namespace ConsoleApp1
{
    class Animal : MovingObject
    {
        public Animal(byte x, byte y) : base(x, y)
        {}

        public override void Move()
        {
            byte x = 0;
            byte y = 0;
            Random ran = new Random();
            x += (byte)ran.Next(1, 3);
            Random ran1 = new Random();
            y += (byte)ran1.Next(0, 2);
            if (Alive) Location = (x, y);
        }
        public override void Grow()
        {
            if (Age < 10) base.Grow();
            else Die();
        }
    }
}