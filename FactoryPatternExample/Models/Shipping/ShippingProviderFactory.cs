namespace FactoryPatternExample.Models.Shipping
{
    internal class ShippingProviderFactory
    {
        public static ShippingProvider CreateShippingFactor(string CountryCode)
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
