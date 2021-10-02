using System;

namespace MethodsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);

            //First overload
            point.Move(new Point(40, 60));

            Console.WriteLine($"Point is at { point.X } {point.Y} ");
            //Second overload
            point.Move(100, 200);

            Console.WriteLine($"Point is at { point.X } {point.Y} ");

            //CALCULATOR - PARAMS
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 10, 40, 50, 60));
            Console.WriteLine(calculator.Add(new int[] { 10, 10, 10 }));

        }
    }
}
