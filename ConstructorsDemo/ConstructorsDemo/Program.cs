using System;

namespace ConstructorsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            var customer2 = new Customer(1);

            var customer3 = new Customer(2, "Paul");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine($" ID: { customer.Id } NAME: { customer.Name } ");
            Console.WriteLine($" ID: { customer2.Id } NAME: { customer2.Name } ");
            Console.WriteLine($" ID: { customer3.Id } NAME: { customer3.Name } ");
        }
    }
}
