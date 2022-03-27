using FactoryPatternExample.Models.Interfaces;

namespace FactoryPatternExample.Models.Entities
{
    public class VATInvoice : IInvoice
    {
        public string GenerateInvoice()
        {
            return "VAT Invoice Created.";
        }
    }
}
