using Game.API.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Games.API.Controllers
{
    public class DeleteController : Controller
    {
        private readonly IGameRepository<GameModel> _gameRepository;

        public DeleteController(IGameRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpDelete("api/game/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                var game = _gameRepository.ObterGameById(id);
                _gameRepository.RemoverGame(game);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new Exception($"Game Não Encontrado {ex}"));
            }
        }
    }
}
