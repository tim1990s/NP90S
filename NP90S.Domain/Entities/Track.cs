using NP90S.Domain.Common;

namespace NP90S.Domain.Entities
{
    public class Track:AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long AlbumId { get; set; }
        public long GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public double UnitPrice { get; set; }
    }
}
