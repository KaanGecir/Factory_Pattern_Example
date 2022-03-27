using FactoryPatternExample.Models.Shipping;

namespace FactoryPatternExample.Models.Factories
{
    public class StandardShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string CountryCode)
        {
            ShippingProvider shippingProvider;

            if (CountryCode == "FR")
            {
                shippingProvider = new FirstShippingProvider();
                // Some Business Logic
                // Like Tax, Insurance etc.
            }
            else if (CountryCode == "SE")
            {
                shippingProvider = new SecondShippingProvider();
                // Some Business Logic
                // Like Tax, Insurance etc.
            }
            else
            {
                throw new NotSupportedException("No shipping provider found for origin country");
            }

            return shippingProvider;
        }
    }
}
