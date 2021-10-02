using System;
using System.Collections.Generic;
using System.Text;

//Base class of other classes for inheritance
namespace Inheritance
{
    public class Presentation
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }

    }
}
