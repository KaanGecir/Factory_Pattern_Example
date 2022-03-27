namespace FactoryPatternExample.Models.Entities
{
    public class Order
    {
        public string Name { get; set; }
        public Address ReceiverAddress { get; set; }

        public string GetShippingInfo()
        {
            return $"This cargo contains {Name}. Will be delivered to {ReceiverAddress.CountryCode}/{ReceiverAddress.City}.";
        }
    }
}
