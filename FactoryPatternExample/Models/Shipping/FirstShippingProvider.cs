using FactoryPatternExample.Models.Entities;

namespace FactoryPatternExample.Models.Shipping
{
    internal class FirstShippingProvider : ShippingProvider
    {
        public override void ShipOrder(Order order)
        {
            Console.WriteLine($"Some FirstShippingProvider Info here. {order.GetShippingInfo()}");
        }
    }
}
