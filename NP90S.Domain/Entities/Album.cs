using NP90S.Domain.Common;

namespace NP90S.Domain.Entities
{
    public class Album : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
