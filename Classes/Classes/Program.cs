using Classes.Math;
using System;

namespace Classes
{
    //Shortcut to see different windows Ctrl + Tab
    class Program
    {

        static void Main(string[] args)
        {
            Person john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(5, 5));

        }
    }
}
