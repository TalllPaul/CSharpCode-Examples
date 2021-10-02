using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied...");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape...");
        }

    }
}
