using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple arithmetic
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine((float)a / (float)b);

            //a more than b, a equals b, a different to b.
            Console.WriteLine("{0} {1} {2}", a > b, a == b, a != b);

            // c is greater than b AND c is greater than a
            Console.WriteLine(c > b && c > a);
            //c is greater than b AND c equals a
            Console.WriteLine(c > b && c == a);
            //c is greater than b OR c equals a
            Console.WriteLine(c > b || c == a);

        }
    }
}
