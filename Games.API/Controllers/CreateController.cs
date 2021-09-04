using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    public class CreateController : Controller
    {
        private readonly IGameRepository<GameModel> _gameRepository;

        public CreateController(IGameRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IGameRepository<GameModel> GameRepository => _gameRepository;

        [HttpPost("api/game")]
        public async Task<ActionResult> Create([FromBody] GameModel game)
        {
            if (game == null)
            {
                return BadRequest();
            }

            await GameRepository.AdicionarGame(game);
            return Created("", game);
        }
    }
}
