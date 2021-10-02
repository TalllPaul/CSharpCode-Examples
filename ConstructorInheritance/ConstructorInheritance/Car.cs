using System;
using System.Collections.Generic;
using System.Text;

//The base keyword uses the constructor of the base class so we can initialise the Car object.

namespace ConstructorInheritance
{
    public class Car : Vehicle
    {

        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised. {0}", registrationNumber);
        }


    }
}
