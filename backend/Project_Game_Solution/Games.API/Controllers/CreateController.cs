using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    public class CreateController : Controller
    {
        private readonly IGenericRepository<GameModel> _gameRepository;

        public CreateController(IGenericRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IGenericRepository<GameModel> GameRepository => _gameRepository;

        [HttpPost("api/game")]
        public async Task<ActionResult> Create([FromBody] GameModel game)
        {
            if (game == null)
            {
                return BadRequest();
            }

            await GameRepository.AddAsync(game);
            return Created("", game);
        }
    }
}
