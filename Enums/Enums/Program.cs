using System;

namespace Enums
{
    //If enum values aren't set the first member will be 0 and from there each member incremented by one. It is better to explicitly set values.
    //Internally an enum is an integer.
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            //Imagine we receive the number 3 to someone else and we want to convert it to the ShippingMethod.

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //convert enum to a string
            Console.WriteLine(method.ToString());

            //Console.WriteLine automatically calls the ToString to any method you pass to it.
            Console.WriteLine(method);

            //Convert string to enum, example the string is stored somewhere else.

            var methodName = "Express";

            //Parse - getting a string and converting it to a different type, parse the string to en enum.
            //It returns an object so we cast to a shipping method.
            var shippingmethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);


        }
    }
}
