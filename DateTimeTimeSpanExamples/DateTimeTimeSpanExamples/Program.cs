using System;

namespace DateTimeTimeSpanExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//TimeSpan - DateTime\\\\");

            //Pass a date.
            DateTime dateTime = new DateTime(2015, 1, 1);
            //Date and time as now
            var now = DateTime.Now;
            //Todays date irrespective of the time
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            //DateTime are immutable, once created you can't change them, only modify.

            //Will return tomorrow at current time
            var tomorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //To convert to string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            //To show date AND time use ToString() You can provide format specifiers in the brackets of the ToString.
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //TIMESPAN - Represents a length of time
            var timeSpan = new TimeSpan(1, 2, 3);

            //These both mean the same but the second one is more readable.
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            //Subtracted from 2 date time objects gives you a timespan....a duration passed.
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; //returns a timespan of 2 minutes.
            Console.WriteLine("Duration = " + duration);

            //TimeSpan properties, a lot come in pairs.
            //The minutes component returns 2 which is the 2 minutes passed as a parameter when creating the object.
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //Total minutes converts all the passed parameters to minutes, so 1 hour, 2 minutes, 3 seconds. (var timeSpan = new TimeSpan(1, 2, 3);)
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

            //Add - immutable, once created can't change it, there are some methods to modify the value, add and subtract.
            //Adds 8 minutes to the timespan. 2 minutes + 8 minutes. (var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Subtracts 2 minutes from the original timespan.
            Console.WriteLine("Add example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Conversion to and from strings
            //ToString - by default console  writeline passes it to string so it isn't necessary to use to string.
            Console.WriteLine("ToString " + timeSpan.ToString());

            //To convert from a string you use Parse.
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
