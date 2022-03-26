using FactoryPatternExample.Models.Entities;

namespace FactoryPatternExample.Models.Shipping
{
    internal class SecondShippingProvider : ShippingProvider
    {
        public override void ShipOrder(Order order)
        {
            Console.WriteLine($"Some SecondShippingProvider Info here. {order.GetShippingInfo()}");
        }
    }
}
