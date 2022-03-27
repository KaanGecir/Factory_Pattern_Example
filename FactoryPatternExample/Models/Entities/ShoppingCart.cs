using FactoryPatternExample.Models.Factories;

namespace FactoryPatternExample.Models.Entities
{
    public class ShoppingCart
    {
        private readonly Order order;
        private readonly IPurchaseProviderFactory purchaseProviderFactory;

        public ShoppingCart(Order order,
            IPurchaseProviderFactory purchaseProviderFactory)
        {
            this.order = order;
            this.purchaseProviderFactory = purchaseProviderFactory;
        }

        public void ShipOrder()
        {
            var shippingProvider = purchaseProviderFactory.CreateShippingProvider(order);

            shippingProvider.ShipOrder(order);

            var invoice = purchaseProviderFactory.CreateInvoice(order);

            invoice.GenerateInvoice();
        }
    }
}
