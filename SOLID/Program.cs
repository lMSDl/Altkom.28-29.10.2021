using SOLID.L;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Program
    {
        static void Main()
        {
            //Rectangle rectangle = new Square();
            Rectangle rectangle = new Rectangle();
            var a = 5;
            var b = 3;

            SetRectangleProperties(rectangle, a, b);
            Console.WriteLine($"Prostojkąt o bokach {a} i {b} ma pole {rectangle.Area}");

        }

        static void SetRectangleProperties(Rectangle rectangle, int width, int height)
        {
            rectangle.A = width;
            rectangle.B = height;
        }

        static void ShowArea(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Area);
        }
    }
}
