namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    //If the price is less than 30, the cost is 10% of the total price of the order, else it is free.
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}