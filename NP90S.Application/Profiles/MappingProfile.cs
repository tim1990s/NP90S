using AutoMapper;
using NP90S.Domain.Entities;
using NP90S.Application.Features.Album.Queries.GetAlbumList;

namespace NP90S.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Album, AlbumListViewModel>();
        }
    }
}
