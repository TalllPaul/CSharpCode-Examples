using System;


//When you create an object, even if it is a derived class inheriting from another class, the base class constructor is always executed first, even if you don't instantiate
//an object of the base class. (eg: Instantiated a Car object only it will first run the Vehicle class constructor.)

namespace ConstructorInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var car = new Car("CNN BHBY");

        }
    }
}
