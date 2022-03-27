using FactoryPatternExample.Models.Entities;
using FactoryPatternExample.Models.Factories;

Order order = new Order()
{
    Name = "Test Product",
    ReceiverAddress = new Address()
    {
        City = "LA",
        CountryCode = "FR"
    }
};

var shoppingCart = new ShoppingCart(order, new StandardShippingProviderFactory());

shoppingCart.ShipOrder();