using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //No searching methods for stringbuilder like there is a string
            Console.WriteLine("//STRINGBUILDER\\\\");

            StringBuilder sb = new StringBuilder("Hello World");

            //Bool, byte, char, char and repeat or char array overloads.
            //This repeats the character the amount of times indicated.
            sb.Append('-', 10);
            Console.WriteLine(sb);

            //AppendLine inserts a line break \r\n, Append edits the string. The Append returns a new stringbuilder.
            sb.AppendLine();
            sb.Append("Header");
            sb.AppendLine();
            sb.Append('-', 10);
            Console.WriteLine(sb);

            //Replaces char with char indicated.
            sb.Replace('-', '+');
            Console.WriteLine(sb);

            //Removes 10 characters starting at index 0
            sb.Remove(0, 10);
            Console.WriteLine(sb);

            //Inserts at index 0 a new string of 10 characters.
            sb.Insert(0, new string('-', 10));
            Console.WriteLine(sb);

            //Let's you view the character at a specific index.
            Console.WriteLine(sb[10]);


        }
    }
}
