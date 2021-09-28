using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Games.API.Controllers
{
    public class GetByIdController : Controller
    {
        private readonly IGenericRepository<GameModel> _gameRepository;

        public GetByIdController(IGenericRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }


        [HttpGet("api/game/{id}")]
        public IActionResult ObterGameById(Guid id)
        {
            var game = _gameRepository.GetById(id);

            if (game == null)
            {
                return BadRequest();
            }

            return Ok(game);
        }
    }
}
