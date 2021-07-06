using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            Shape circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var heigth = int.Parse(Console.ReadLine());
            Shape rect = new Rectangle(width, heigth);

            circle.Draw();
            Console.WriteLine(rect.Draw());
        }
    }
}
