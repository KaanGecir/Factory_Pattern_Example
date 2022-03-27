using FactoryPatternExample.Models.Entities;
using FactoryPatternExample.Models.Interfaces;
using FactoryPatternExample.Models.Shipping;

namespace FactoryPatternExample.Models.Factories
{
    public class FirstPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new NoVATInvoice();
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            ShippingProviderFactory shippingProviderFactory = new StandardShippingProviderFactory();

            return shippingProviderFactory.GetShippingFactor(order.ReceiverAddress.CountryCode);
        }
    }
}
