using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Can ve converted without data loss because a byte is 1 byte, an int is 4 bytes. 
            byte b = 1;
            int i = b;
            */

            //this will give an error because you cannot implicitly convert int to byte as the int has more bytes than the byte. You would have to use an explicit conversion (cast).
            //byte b = (byte) i; no data loss will happen because the value is small enough to fit in one byte.
            //Any value over 255 (maxValue of byte) will lose data (1000 for example). If you use int 1000 the result of b will be 232 only as bits are lost.
            int i = 1;
            byte b = (byte)i;

            Console.WriteLine(b);

            //NON COMPATIBLE TYPES
            //If it says a type can't be converted you have to use the Convert class as the types are not compatible.

            string number = "1234";
            int c = Convert.ToInt32(number);

            Console.WriteLine(c);

            //If we try to convert the string to a byte it will show an error as the value of number is too large for a byte. System.OverflowException, value too
            //large or too small and the program will crash. You have to 
            //control the error.

            try
            {

                byte d = Convert.ToByte(number);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte. Number value is too large.");

            }

            string str = "true";
            bool f = Convert.ToBoolean(str);

            Console.WriteLine(f);


        }
    }
}
