using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Shape1D : Shape
    {
        protected Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        public int Width { get; protected set; }

        public override string ToString()
        {
            return $"{base.ToString()} o szerokości {Width}";
        }
    }
}
