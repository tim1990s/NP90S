using AutoMapper;
using MediatR;
using NP90S.Application.Contracts.Persistence.AlbumEntity;

namespace NP90S.Application.Features.Album.Queries.GetAlbumList;

public class GetAlbumListHandler:IRequestHandler<GetAlbumListQuery, List<AlbumListViewModel>>
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IMapper _mapper;
    
    public GetAlbumListHandler(IMapper mapper, IAlbumRepository albumRepository)
    {
        _mapper = mapper;
        _albumRepository = albumRepository;
    }

    public async Task<List<AlbumListViewModel>> Handle(GetAlbumListQuery request, CancellationToken cancellationToken)
    {
        var albums = (await _albumRepository.GetAlbums()).OrderBy(x => x.Title);
        return _mapper.Map<List<AlbumListViewModel>>(albums);
    }
}