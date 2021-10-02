using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingDowncasting
{
    /*
     * Sometimes with inheritance you have to convert a derived class to a base class (upcasting), the base class to a derived class (downcasting) 
     * using the as and is keywords to control exceptions.
     * 
     * StringReader reads data from any stream of any kind.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Upcasting and Downcasting***");

            //Upcast. We implicitly convert the object reference like text to a base class reference like Shape.
            //The text and shape objects point to the same object in memory but they have different views.
            var text = new Text();
            Shape shape = text;

            //The text object has access to the inherited its fields and its own fields, the casted shape object only has access to the Shape fields.

            text.Width = 200;
            shape.Width = 100;
            //This will print out 100 because both text and shape are referencing the same object, just with different views.
            Console.WriteLine("{0}", text.Width);

            //REAL WORLD EXAMPLE OF UPCASTING/DOWNCAST - When we pass a MemoryStream it is actually upcasting automatically to the parent class Stream.
            StreamReader reader = new StreamReader(new MemoryStream());

            //Another example: To the Add method any object can be passed to it without any conversion being required, they'll all be implicitly converted to the base class.
            var list = new ArrayList();
            list.Add(new Text());

            var list2 = new List<int>();

            //DOWNCASTING

            //At compile time the object is a shape but at runtime it is a Text object. If we look at the Shape object without casting we can see that we can only see the fields of the
            //Shape class, to view also the fields of the Text class we need to downcast.

            Shape shaper = new Text();
            //convert shape to text
            Text text2 = (Text)shape;

            //Real world example of downcasting:
            //**View project DowncastDemo**

            

        }
    }
}
