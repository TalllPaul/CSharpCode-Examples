using System;

namespace EnterAValidTimeProgram
{
    /*
     * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
     * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
     * If the user doesn't provide any values, consider it as invalid time.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time (24-hour format): ");
            var input = Console.ReadLine();

            //Checks if it is null or whitespace
            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            //Splits the input up from the colon and creates an array, at index 0 the hour, and index 1 the minutes.
            var components = input.Split(':');

            //If the array has more or less than 2 values, invalid time.
            if(components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                    return;
            }

            try
            {
                //Convert the hour and minute into an int as to compare in the if condition.
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                //Checks the hour and minutes are inside the right range. 
                if(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                {
                    Console.WriteLine("OK");
                } else
                {
                    Console.WriteLine("Invalid time");
                }

            } catch(Exception e)
            {
                Console.WriteLine("Invalid Time");
            }


        }
    }
}
