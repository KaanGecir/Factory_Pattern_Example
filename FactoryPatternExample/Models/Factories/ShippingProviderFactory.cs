using FactoryPatternExample.Models.Shipping;

namespace FactoryPatternExample.Models.Factories
{
    public abstract class ShippingProviderFactory
    {
        public abstract ShippingProvider CreateShippingProvider(string CountryCode);
        public ShippingProvider GetShippingFactor(string CountryCode)
        {
            var shippingProvider = this.CreateShippingProvider(CountryCode);

            if (CountryCode == "FR")
            {
                Console.WriteLine("Some first shipping provider exclusive logic here...\n");
            }

            return shippingProvider;
        }
    }
}
