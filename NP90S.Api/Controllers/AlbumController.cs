using MediatR;
using Microsoft.AspNetCore.Mvc;
using NP90S.Application.Features.Album.Queries.GetAlbumList;

namespace NP90S.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;
        private readonly IMediator _mediator;

        public AlbumController(ILogger<AlbumController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAlbum")]
        public async Task<ActionResult<List<AlbumListViewModel>>> Get()
        {
            _logger.LogInformation("Begin all albums");
            var albums = await _mediator.Send(new GetAlbumListQuery());
            return Ok(albums);
        }
    }
}