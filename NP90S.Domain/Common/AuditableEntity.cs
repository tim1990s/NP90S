namespace NP90S.Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public long CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public long? LastModifiedDate { get; set; }
    }
}
