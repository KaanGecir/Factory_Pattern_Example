using FactoryPatternExample.Models.Entities;

namespace FactoryPatternExample.Models.Shipping
{
    internal abstract class ShippingProvider
    {
        public abstract void ShipOrder(Order order);
    }
}
