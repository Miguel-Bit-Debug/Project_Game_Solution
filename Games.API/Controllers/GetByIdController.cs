using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Games.API.Controllers
{
    public class GetByIdController : Controller
    {
        private readonly IGameRepository<GameModel> _gameRepository;

        public GetByIdController(IGameRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }


        [HttpGet("api/game/{id}")]
        public IActionResult ObterGameById(Guid id)
        {
            var game = _gameRepository.ObterGameById(id);

            if (game == null)
            {
                return BadRequest();
            }

            return Ok(game);
        }
    }
}
