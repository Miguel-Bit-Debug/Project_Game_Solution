using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    public class DeleteController : Controller
    {
        private readonly IGenericRepository<GameModel> _gameRepository;

        public DeleteController(IGenericRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpDelete("api/game/{id}")]
        public async Task<ActionResult> Remove(Guid id)
        {
            try
            {
                var game = _gameRepository.GetById(id);
                await _gameRepository.RemoveAsync(game);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new Exception($"Game Não Encontrado {ex}"));
            }
        }
    }
}
