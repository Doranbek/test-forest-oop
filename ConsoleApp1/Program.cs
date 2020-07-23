using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main()
        {
            var lake1 = new Lake(40, 40, 60, 60, 500);
            var stone1 = new Stone(20, 0, 0);

            var tree1 = new Tree(3, 10, 25);

            var animal1 = new Animal(3, 4);
            var bird1 = new Bird(1, 20);

            animal1.Move(40, 40);

            bird1.Move(3, 10);
            bird1.Nest(tree1);

            for (int i = 0; i < 10; i++)
            {
                tree1.Grow();
                animal1.Grow();
                bird1.Grow();
            }
        }
    }
}