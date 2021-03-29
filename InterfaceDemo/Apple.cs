using ConsoleGraphicsEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class Apple : IJsonRepresentable, IDrawable
    {
        public Apple(int health)
        {
            Health = health;
        }

        public override string ToString()
        {
            return $"Apple, hp = {Health}";
        }

        public string ToJson()
        {
            return $"{{ \"health\": {Health} }}";
        }

        public string Draw()
        {
            return $"APPLE - {Health} hp";
        }

        public int Health { get; private set; }
    }
}
