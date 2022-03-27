using FactoryPatternExample.Models.Entities;
using FactoryPatternExample.Models.Interfaces;
using FactoryPatternExample.Models.Shipping;

namespace FactoryPatternExample.Models.Factories
{
    public class SecondPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            if (order.ReceiverAddress.CountryCode == "SE")
            {
                return new NoVATInvoice();
            }

            return new VATInvoice();
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            ShippingProviderFactory shippingProviderFactory;

            if (order.ReceiverAddress.CountryCode == "SE")
            {
                shippingProviderFactory = new GlobalShippingProviderFactory();
            }
            else
            {
                shippingProviderFactory = new StandardShippingProviderFactory();
            }

            return shippingProviderFactory.GetShippingFactor(order.ReceiverAddress.CountryCode);
        }
    }
}
