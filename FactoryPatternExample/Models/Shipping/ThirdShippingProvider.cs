using FactoryPatternExample.Models.Entities;

namespace FactoryPatternExample.Models.Shipping
{
    public class ThirdShippingProvider : ShippingProvider
    {
        public override void ShipOrder(Order order)
        {
            Console.WriteLine($"Some Third and Global ShippingProvider Info here. {order.GetShippingInfo()}");
        }
    }
}
