using System;
using LibraryAmazon;

namespace AccessModifiersDemo
{
    /*

        Public: Accessible from everywhere.

        Private: Accessible only from the class, needs getters and setters. 

        Protected: Accessible only from the class and derived classes. Like private but if we derive a class, it will be visible from it.  Best to use private as this breaks encapsulation.

        Internal: Accessible only from the same assembly. Used for classes so only those of the same domain/class library can access it. 

        Protected Internal: Accessible only from the same assembly or derived classes. 

    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Acess Modifiers*");

            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());

            var person2 = new Person();
            Console.WriteLine($"Date with public get but private set { person2.Name }");

            var person3 = new Person();
            person3.Birthdate = new DateTime(1983, 12, 27);

            Console.WriteLine(person3.Age);

            //Customer class

            var customer = new LibraryAmazon.Customer();
           
            
           
        }
    }
}
