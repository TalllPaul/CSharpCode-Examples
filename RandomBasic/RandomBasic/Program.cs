using System;

namespace RandomBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            //next returns a random integer
            //NextBytes returns a byte array filled with random numbers.
            //nextdouble returns random double between 0.0 and 1.0
            const int passwordLength = 10;
            var buffer = new char[passwordLength];


            for (var i = 0; i < passwordLength; i++)
            {
                //creates a random string by converting the int of the Next to a char.

                buffer[i] = (char)('a' + rand.Next(0, 26));
            }

                var password = new string(buffer);
            
                Console.WriteLine(password);
            

            //Console.WriteLine((int)'a');
        }
    }
}
