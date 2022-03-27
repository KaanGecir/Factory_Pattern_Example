using FactoryPatternExample.Models.Interfaces;

namespace FactoryPatternExample.Models.Entities
{
    public class NoVATInvoice : IInvoice
    {
        public string GenerateInvoice()
        {
            return "No VAT Invoice Created...";
        }
    }
}
