using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*INHERITANCE*");

            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
