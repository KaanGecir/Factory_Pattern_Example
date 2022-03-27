using FactoryPatternExample.Models.Factories;

namespace FactoryPatternExample.Models.Entities
{
    public class ShoppingCart
    {
        private readonly Order order;
        private readonly ShippingProviderFactory shippingProviderFactory;

        public ShoppingCart(Order order,
            ShippingProviderFactory shippingProviderFactory)
        {
            this.order = order;
            this.shippingProviderFactory = shippingProviderFactory;
        }

        public void ShipOrder()
        {
            var shippingProvider = shippingProviderFactory.GetShippingFactor(order.ReceiverAddress.CountryCode);

            shippingProvider.ShipOrder(order);
        }
    }
}
