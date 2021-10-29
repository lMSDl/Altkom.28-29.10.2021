using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Elipse : Shape2D
    {
        public Elipse(int width, int height) : base("Elipsa", height, width)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Width / 2.0 * Height / 2.0;
        }
    }
}
