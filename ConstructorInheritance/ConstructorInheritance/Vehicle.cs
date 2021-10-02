using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        /*public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialised");
        }*/

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialised. {0}", registrationNumber);
        }

    }
}
