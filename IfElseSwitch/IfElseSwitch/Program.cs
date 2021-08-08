using System;

namespace IfElseSwitch
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /* 
             * int hour = 10;

            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            } else if(hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's the afternoon");
            } else
            {
                Console.WriteLine("It's evening");
            }

            */

            
            bool isGoldCustomer = true;
           /* float price = 0.0f;
            if(isGoldCustomer)
            {
                price = 19.06f;
            } else
            {
                price = 29.95f;
            }

            Console.WriteLine(price);
            */

            //conditional operator - if gold customer = 19.95 else = 29.95
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            //SWITCH
            var seasons = Season.Autumn;

            switch(seasons)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;
                case Season.Spring:
                    Console.WriteLine("Spring");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer");
                    break;
                case Season.Winter:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Don't know the season");
                    break;


            }

            /* 
             * For more than one condition to show the same message you can leave one empty, example:
             * case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("Spring");
                    break;

            This will show the message Spring for both Autumn and Spring.
            */


        }
    }
}
