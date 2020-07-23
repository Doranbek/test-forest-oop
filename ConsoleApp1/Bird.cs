namespace ConsoleApp1
{
    class Bird : MovableObject
    {
        public Tree HomeTree { get; private set; }

        public Bird(byte x, byte y) : base(x, y)
        {}

        public void Nest(Tree tree) => HomeTree = tree;
    }
}