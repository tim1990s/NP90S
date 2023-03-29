using NP90S.Domain.Common;

namespace NP90S.Domain.Entities
{
    public class Invoice:AuditableEntity
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public double Total { get; set; }
    }
}
