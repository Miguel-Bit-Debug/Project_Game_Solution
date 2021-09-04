using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
        public async Task<ActionResult> Remove(Guid id)
        {
            try
            {
                var game = _gameRepository.ObterGameById(id);
                await _gameRepository.RemoverGame(game);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new Exception($"Game Não Encontrado {ex}"));
            }
        }
    }
}
