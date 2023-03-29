using MediatR;

namespace NP90S.Application.Features.Album.Queries.GetAlbumList;

public class GetAlbumListQuery: IRequest<List<AlbumListViewModel>>
{
}