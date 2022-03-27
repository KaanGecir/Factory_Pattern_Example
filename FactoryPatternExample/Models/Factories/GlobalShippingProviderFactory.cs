using FactoryPatternExample.Models.Shipping;

namespace FactoryPatternExample.Models.Factories
{
    public class GlobalShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string CountryCode)
        {
            return new ThirdShippingProvider();
        }
    }
}
