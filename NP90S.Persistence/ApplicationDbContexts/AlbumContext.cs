using MongoDB.Driver;
using NP90S.Domain.Entities;
using Microsoft.Extensions.Options;
using NP90S.Application.Models.Album;
using Microsoft.Extensions.Configuration;
using NP90S.Application.Contracts.Persistence.AlbumEntity;

namespace NP90S.Persistence.ApplicationDbContexts
{
  public class AlbumContext : IAlbumContext
    {
        public AlbumContext(IConfiguration configuration, IOptions<AlbumMongoContextOption> albumMongoContextOption)
        {
            var albumDatabaseOptions = albumMongoContextOption.Value;
            var client = new MongoClient(albumDatabaseOptions.ConnectionString);
            var database = client.GetDatabase(albumDatabaseOptions.DatabaseName);
            Albums = database.GetCollection<Album>(albumDatabaseOptions.CollectionName);
            AlbumContextSeed.SeedData(Albums);
        }

        public IMongoCollection<Album> Albums { get; }
    }
}
