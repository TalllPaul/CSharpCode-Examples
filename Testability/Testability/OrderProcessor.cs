using System;

namespace Testability
{
    public class OrderProcessor
    {
        //Shipping calculator is used to calculate the shipping costs.
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        //We have a Unit test for this method. The first test is if order is shipped, it will throw an exception. 
        public void Process(Order order)
        {
            //if it is shipped we don't want to ship it again so we say it has been processed.
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                //If it hasn't been shipped, we calculate the order cost with the shippingcalculator and the date of the shipment. 
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}