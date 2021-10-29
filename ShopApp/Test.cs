using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    public class Test
    {
        public void Execute()
        {
            Shape shape = new Point();
            Shape1D shape1D = new Line(15);
            Shape2D shape2D = new Rectangle(15, 20);
            Elipse elipse = new Elipse(5, 10);
            Shape elipseShape = elipse; 

            PrintName(shape);
            PrintName(shape1D);
            PrintWidth(shape2D);
            PrintWidth(elipse);

            PrintArea(elipse);
            PrintArea(shape2D);
            PrintName(elipseShape);
        }

        public void PrintName(Shape shape)
        {
            Console.WriteLine(shape);
        }
        public void PrintWidth(Shape1D shape)
        {
            Console.WriteLine(shape.Width);
        }
        public void PrintArea(Shape2D shape)
        {
            Console.WriteLine(shape.GetArea());
        }
    }
}
