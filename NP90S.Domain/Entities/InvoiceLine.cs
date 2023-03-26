using NP90S.Domain.Common;

namespace NP90S.Domain.Entities
{
    public class InvoiceLine:AuditableEntity
    {
        public long Id { get; set; }
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
    }
}
