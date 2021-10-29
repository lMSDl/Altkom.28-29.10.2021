using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Rectangle : Shape2D
    {
        public Rectangle(int width, int height) : base("Prostokąt", height, width)
        {
        }

        public override double GetArea()
        {
            return Height * Width;
        }
    }
}
