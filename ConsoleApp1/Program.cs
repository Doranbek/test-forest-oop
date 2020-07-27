using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Forest
    {
        readonly static List<ObjectWithLocation> Objects = new List<ObjectWithLocation>();
        readonly static List<LivingObject> LivingObjects = new List<LivingObject>();
        readonly static List<MovingObject> MovingObject = new List<MovingObject>();


        static void Main()
        {
            // Populate forest
            var lake1 = new Lake(40, 40, 60, 60, 500);
            var stone1 = new Stone(20, 7, 15);
            var mountain1 = new Mountain(80, 75, 1300);

            Objects.Add(lake1);
            Objects.Add(stone1);
            Objects.Add(mountain1);

            LivingObject tree1 = new Tree(3, 10, 25);

            var animal1 = new Animal(3, 4);
            var bird1 = new Bird(1, 20);

            LivingObjects.Add(tree1);
            LivingObjects.Add(animal1);
            LivingObjects.Add(bird1);

            MovingObject.Add(animal1);
            MovingObject.Add(bird1);

            // Forest commands
            while (true)
            {
                Print();

                var input = Console.ReadLine();

                switch (input)
                {
                    case "next":
                        Continue();
                        break;                   
                    default:
                        ObjMove();
                        break;
                }
            }
        }

        static void Continue()
        {
            Console.WriteLine("\nOne year later...\n");

            foreach (var obj in LivingObjects)
            {
                obj.Grow();
            }
        }

        static void ObjMove()
        {
            Console.WriteLine("\nOne month later...\n");

            foreach (var obj in MovingObject)
            {
                obj.Move();
            }
        }



        static void Print()
        {
            Console.WriteLine("Satus:\n");

            foreach (var obj in Objects)
            {
                Console.WriteLine($"{obj.GetType()}'s locations is {obj.Location}");
            }

            foreach (var obj in LivingObjects)
            {
                Console.WriteLine($"{obj.GetType()}'s locations is {obj.Location}");
                Console.WriteLine($"\tAlive? {obj.Alive}. Age: {obj.Age}");
            }
        }
    }
}