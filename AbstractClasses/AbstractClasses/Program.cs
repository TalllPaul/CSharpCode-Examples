using System;

//Abstract classes indicates a class or member is missing implementation. The class must be marked as abstract also, the members don't have a body and the derived classes
//must implement what is missing from the base class. It can be used to force your applications design, for example, always have a Draw() method.

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***ABSTRACT CLASSES***");



            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
