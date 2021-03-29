using ConsoleGraphicsEngine;
using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player john = new Player("John Rambo");
            john.AddScore(123);
            Console.WriteLine(john);
            Console.WriteLine(john.ToJson());

            Apple apple = new Apple(23);
            Console.WriteLine(apple);
            Console.WriteLine(apple.ToJson());

            List<IJsonRepresentable> jsonObjects = new List<IJsonRepresentable>();

            jsonObjects.Add(john);
            jsonObjects.Add(apple);

            Console.WriteLine("Polymorphism at work");
            foreach (var item in jsonObjects)
            {
                Console.WriteLine(item.ToJson());
            }

            Console.WriteLine("\n\n GRAPHICS \n\n");
            GraphicsEngine engine = new GraphicsEngine();
            engine.Draw(apple);
            engine.Draw(john);
        }
    }
}
