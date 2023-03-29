using MongoDB.Driver;
using NP90S.Domain.Entities;

namespace NP90S.Persistence.ApplicationDbContexts
{
  public class AlbumContextSeed
  {

    public static void SeedData(IMongoCollection<Album> albums)
    {
      bool existAlbum = albums.Find(p => true).Any();
      if (!existAlbum)
      {
        albums.InsertManyAsync(GetPreconfiguredAlbums());
      }
    }

    private static IEnumerable<Album> GetPreconfiguredAlbums()
    {
      return new List<Album>()
      {
          new Album()
          {
              Id= 1,
              CreatedBy= "John",
              CreatedDate = 1680044193,
              LastModifiedBy = "Peter",
              LastModifiedDate = 0,
              Title = "Under the cover"
          }
      };
    }
  }
}
