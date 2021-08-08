using System;

namespace RefTypesValueTypes
{
    public class Person
    {
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = 10;
            var b = a;
            b++;
            //At this point a = 10 because integers are value types, when we copy a value type to another variable, a copy is taken and stored in the target variable in memory. The values are copied.
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //Arrays are classes, reference types.
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //The first element is 0 because it is a reference type. Both arrays in the stack point to the same address on the heap. When they are copied, the memory address is copied, not the value.
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            //FOR PERSON EXAMPLES
            var number = 1;
            Increment(number);
            //number will be 1 as it is a value type, a copy is sent to the method.
            Console.WriteLine(number);

            var person = new Person() { age = 20 };
            MakeOld(person);
            //A reference object is passed and because it is a reference type, both the person in the main and in the method will change as they point to the same address.
            Console.WriteLine(person.age);

        }

        //static to call them without having to create an object.
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
}
