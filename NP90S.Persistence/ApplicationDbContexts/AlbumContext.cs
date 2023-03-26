using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using NP90S.Application.Contracts.Persistence;
using NP90S.Domain.Entities;

namespace NP90S.Persistence.ApplicationDbContexts
{
    public class AlbumContext : IAlbumContext
    {
        public AlbumContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Albums = database.GetCollection<Album>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            //AlbumsContextSeed.SeedData(Albums);
        }

        public IMongoCollection<Album> Albums { get; }
    }
}
