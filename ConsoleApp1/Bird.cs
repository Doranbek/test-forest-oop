using System;

namespace ConsoleApp1
{
    class Bird : MovingObject
    {
        
        public Tree HomeTree { get; private set; }

        public Bird(byte x, byte y) : base(x, y)
        {}

        public void Nest(Tree tree) => HomeTree = tree;

        public override void Move()
        {
            byte x = 0;
            byte y = 0;
            Random ran = new Random();
            x += (byte)ran.Next(1, 4);
            Random ran1 = new Random();
            y += (byte)ran1.Next(1, 4);
            if (Alive) Location = (x, y);

        }

        public override  void Grow()
        {
            if (Age < 10) base.Grow();
            else Die();
        }
    }
}