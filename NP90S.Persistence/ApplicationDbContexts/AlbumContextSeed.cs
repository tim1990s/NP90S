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
              CreatedBy= "John Papa",
              CreatedDate = 1680044193,
              LastModifiedBy = "Peter White",
              LastModifiedDate = 0,
              Title = "What Right Thing To Do."
          },
          new Album()
          {
            Id= 2,
            CreatedBy= "Stive",
            CreatedDate = 1680044193,
            LastModifiedBy = "Tim Nguyen",
            LastModifiedDate = 0,
            Title = "C# 10.0 For The Beginner."
          }
      };
    }
  }
}
