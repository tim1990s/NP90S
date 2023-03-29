using MongoDB.Driver;
using NP90S.Domain.Entities;

namespace NP90S.Application.Contracts.Persistence.AlbumEntity
{
    public interface IAlbumContext
    {
        IMongoCollection<Album> Albums { get; }
    }
}
