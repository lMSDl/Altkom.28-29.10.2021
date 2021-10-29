using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Shape2D : Shape1D
    {
        protected Shape2D(string name, int height, int width) : base(name, width)
        {
            Height = height;
        }

        public int Height { get; protected set; }

        public abstract double GetArea();

        public override string ToString()
        {
            return $"{base.ToString()} i wysokości {Height}";
        }
    }
}
