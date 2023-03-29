using NP90S.Domain.Common;

namespace NP90S.Domain.Entities
{
    public class PlaylistTrack:AuditableEntity
    {
        public long Id { get; set; }
        public long TrackId { get; set; }
    }
}
