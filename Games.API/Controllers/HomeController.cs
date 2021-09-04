using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Games.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository<GameModel> _gameRepository;

        public HomeController(IGameRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet("api/game")]
        public IActionResult Index()
        {
            var game = _gameRepository.ListarGame();
            return Ok(game);
        }
    }
}
