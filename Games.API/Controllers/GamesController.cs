using Game.API.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Chapter.Sync.API.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet("api/game")]
        public IActionResult Index()
        {
            var game = _gameRepository.ListarGame();
            return Ok(game);
        }

        [HttpPost("api/game")]
        public IActionResult GameAdd([FromForm] GameModel game)
        {
            if (game == null)
            {
                return BadRequest();
            }

            _gameRepository.AdicionarGame(game);
            return Created("", game);
        }

        [HttpPut("api/game/{id}")]
        public IActionResult UpdateGame(Guid id, [FromBody] GameModel game)
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

        [HttpDelete("api/game/{id}")]
        public IActionResult RemoverGame(Guid id)
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
