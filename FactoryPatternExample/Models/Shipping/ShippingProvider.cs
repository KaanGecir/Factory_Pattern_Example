using FactoryPatternExample.Models.Entities;

namespace FactoryPatternExample.Models.Shipping
{
    public abstract class ShippingProvider
    {
        public abstract void ShipOrder(Order order);
    }
}
