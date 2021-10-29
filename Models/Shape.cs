using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Shape
    {
        protected Shape(string name)
        {
            Name = name;
        }

        private string Name { get; }



        public override string ToString()
        {
            return Figgle.FiggleFonts.Standard.Render(Name);
        }

        public void SomeMethod()
        {

        }
        public virtual void SomeVirtualMethod()
        {
            Console.WriteLine("Hello");
        }
    }
}
