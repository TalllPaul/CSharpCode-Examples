using System;
using System.Text.RegularExpressions;

// https://www.tutorialspoint.com/csharp/csharp_regular_expressions.htm
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
// https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-5.0
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/anchors-in-regular-expressions



namespace RegexProgram
{


    /*
     * ^ = start at beginning of string.
     * \d = match any decimal digit.
     * { } = amount if digits.
     * | = or
     * \z = match must occur at end of string only.
     * */
    public class Program
    {
        static void Main(string[] args)
        {
            string pin = null;
            //string pin = "1234\n";
            do
            {
                Console.WriteLine("Enter a 4 or 6 digit number...");
                pin = Console.ReadLine();
            } while (CheckPattern(pin));

            Console.WriteLine("Caracteres introducidos incorrectos");

            //Console.WriteLine(CheckPattern(pin));
            Console.ReadKey();
        }

        public static bool CheckPattern(string pin)
        {

            return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");

        }
    }
}
