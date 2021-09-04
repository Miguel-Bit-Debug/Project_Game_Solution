using Game.Library.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Games.API.Controllers
{
    public class UpdateController : Controller
    {
        private readonly IGameRepository<GameModel> _gameRepository;

        public UpdateController(IGameRepository<GameModel> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpPut("api/game/{id}")]
        public IActionResult Update(Guid id, [FromBody] GameModel game)
        {
            var gameAntigo = _gameRepository.ObterGameById(id);
            if (gameAntigo == null)
            {
                return BadRequest();
            }

            gameAntigo.Nome = game.Nome;
            gameAntigo.Descricao = game.Descricao;
            gameAntigo.MaiorDeIdade = game.MaiorDeIdade;
            gameAntigo.Multiplayer = game.Multiplayer;
            gameAntigo.MaiorDeIdade = game.MaiorDeIdade;
            gameAntigo.DataLancamento = game.DataLancamento;

            _gameRepository.AlterarGame(gameAntigo);

            return Ok(game);
        }
    }
}
