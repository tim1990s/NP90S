using NP90S.Domain.Entities;

namespace NP90S.Application.Contracts.Persistence.AlbumEntity
{
  public interface IAlbumRepository
  {
    Task<IEnumerable<Album>> GetAlbums();
    Task<Album> GetAlbum(int id);
    Task<IEnumerable<Album>> GetAlbumByTitle(string title);
    Task CreateAlbum(Album album);
    Task<bool> UpdateAlbum(Album album);
    Task<bool> DeleteAlbum(int id);
  }
}
