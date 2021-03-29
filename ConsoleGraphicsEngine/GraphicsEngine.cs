using System;

namespace ConsoleGraphicsEngine
{
    public class GraphicsEngine
    {
        public void Draw(IDrawable obj)
        {
            Console.WriteLine("DRAWING .... " + obj.Draw() + " ....");
        }
    }
}
