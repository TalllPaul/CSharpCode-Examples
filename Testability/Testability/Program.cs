using System;
//Interfaces imporve testability
namespace Testability
{
    class Program
    {
        //Simulated basic order processor.
        static void Main(string[] args)
        {
            
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            
            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100f};

            orderProcessor.Process(order);
        }
    }
}
