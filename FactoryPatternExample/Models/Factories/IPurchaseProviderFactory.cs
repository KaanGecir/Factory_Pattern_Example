using FactoryPatternExample.Models.Entities;
using FactoryPatternExample.Models.Interfaces;
using FactoryPatternExample.Models.Shipping;

namespace FactoryPatternExample.Models.Factories
{
    public interface IPurchaseProviderFactory
    {
        ShippingProvider CreateShippingProvider(Order order);
        IInvoice CreateInvoice(Order order);
    }
}
