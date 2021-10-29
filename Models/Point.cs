using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Point : Shape1D
    {
        public Point() : base("Punkt", 1)
        {
        }

        public override void SomeVirtualMethod()
        {
            Console.WriteLine("bye");
        }
    }
}
