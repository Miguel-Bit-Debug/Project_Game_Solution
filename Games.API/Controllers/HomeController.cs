using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Games.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericRepository<GameModel> _gameRepository;

        public HomeController(IGenericRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet("api/game")]
        public IActionResult Index()
        {
            var game = _gameRepository.List();
            return Ok(game);
        }
    }
}
