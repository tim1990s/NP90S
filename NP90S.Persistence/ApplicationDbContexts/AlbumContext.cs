using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NP90S.Application.Contracts.Persistence.AlbumEntity;
using NP90S.Application.Models.Album;
using NP90S.Domain.Entities;

namespace NP90S.Persistence.ApplicationDbContexts
{
  public class AlbumContext : IAlbumContext
    {
        private readonly AlbumMongoContextOption _albumMongoContextOption;

        public AlbumContext(IConfiguration configuration, IOptions<AlbumMongoContextOption> albumMongoContextOption)
        {
            _albumMongoContextOption = albumMongoContextOption.Value;
            var client = new MongoClient(configuration.GetValue<string>(_albumMongoContextOption.ConnectionString));
            var database = client.GetDatabase(configuration.GetValue<string>(_albumMongoContextOption.DatabaseName));
            Albums = database.GetCollection<Album>(configuration.GetValue<string>(_albumMongoContextOption.CollectionName));
            AlbumContextSeed.SeedData(Albums);
        }

        public IMongoCollection<Album> Albums { get; }
    }
}
