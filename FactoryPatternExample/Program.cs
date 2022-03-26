using FactoryPatternExample.Models.Entities;
using FactoryPatternExample.Models.Shipping;

Order order = new Order()
{
    Name = "Test Product",
    ReceiverAddress = new Address()
    {
        City = "LA",
        CountryCode = "FR"
    }
};

var shippingProvider = ShippingProviderFactory.CreateShippingFactor(order.ReceiverAddress.CountryCode);

shippingProvider.ShipOrder(order);