using NP90S.Application.Contracts.Persistence.AlbumEntity;
using NP90S.Domain.Entities;
using MongoDB.Driver;

namespace NP90S.Persistence.Repositories;

public class AlbumRepository:IAlbumRepository
{
    private readonly IAlbumContext _context;

    public AlbumRepository(IAlbumContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Album>> GetAlbums()
    {
        return await _context.Albums
            .Find(p => true)
            .ToListAsync();
    }

    public async Task<Album> GetAlbum(int id)
    {
        return await _context
            .Albums
            .Find(p => p.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Album>> GetAlbumByTitle(string title)
    {
        FilterDefinition<Album> filter = Builders<Album>.Filter.ElemMatch(p => p.Title, title);
        return await _context
            .Albums
            .Find(filter)
            .ToListAsync();
    }

    public async Task CreateAlbum(Album album)
    {
        await _context.Albums.InsertOneAsync(album);
    }

    public async Task<bool> UpdateAlbum(Album album)
    {
        var updateResult = await _context.Albums.ReplaceOneAsync(filter: g => g.Id == album.Id, replacement: album);
        return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
    }

    public async Task<bool> DeleteAlbum(int id)
    {
        FilterDefinition<Album> filter = Builders<Album>.Filter.Eq(p => p.Id, id);
        DeleteResult deleteResult = await _context.Albums.DeleteOneAsync(filter);
        return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
    }
}