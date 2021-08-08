using System;

namespace StringsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+STRINGS+");

            var fullName = "Bob Monkhouse ";

            //Trim() + Removes leading and trailing whitepace
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            //Trims and makes uppercase
            Console.WriteLine("Uppercase {0}", fullName.Trim().ToUpper());

            //Separate into first and last name
            //Get the index of the space
            var index = fullName.IndexOf(' ');
            //Create a substring for the first name starting at the first index to the space.
            var firstName = fullName.Substring(0, index);
            //Create a substring for the last name starting at the index after the whitespace until the end.
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            //Separate it using split that returns the split text as a string array.
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            //Replaces the name of the string with another name, replace lowercase o with uppercase, replaces spaces with no spaces.
            Console.WriteLine(fullName.Replace("Bob", "Dave"));
            Console.WriteLine(fullName.Replace('o', 'O'));
            Console.WriteLine(fullName.Replace(" ", ""));

            //Work with empty strings and nulls
            if(String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            //Convert string to number
            var str = "25";
            //Convrts the string to num
            var num = Convert.ToInt32(str);
            Console.WriteLine(num);

            //Convert number to string
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));



        }
    }
}
