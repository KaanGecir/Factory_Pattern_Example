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

IPurchaseProviderFactory purchaseProviderFactory;

if (order.ReceiverAddress.CountryCode == "FR")
{
    purchaseProviderFactory = new FirstPurchaseProviderFactory();
}
else if (order.ReceiverAddress.CountryCode == "SE")
{
    purchaseProviderFactory = new SecondPurchaseProviderFactory();
}
else
{
    throw new NotSupportedException("Sender country has no purchase provider");
}

var shoppingCart = new ShoppingCart(order, purchaseProviderFactory);

shoppingCart.ShipOrder();