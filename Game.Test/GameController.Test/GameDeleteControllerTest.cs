using Game.API.AppDbContext;
using Game.API.Controllers;
using Game.API.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace Game.Test.GameController.Test
{
    public class GameDeleteControllerTest
    {
        public Mock<IGameRepository<GameModel>> _repository;
        public GamesController _controller;
        public AppDBContext _context;

        public GameDeleteControllerTest()
        {
            _repository = new Mock<IGameRepository<GameModel>>();
            _controller = new GamesController(_repository.Object);
        }

        [Fact]
        public void DeveRemoverGame()
        {
            var game = new GameModel()
            {
                GameId = Guid.NewGuid(),
                DataLancamento = DateTime.Now,
                Descricao = "Foda",
                MaiorDeIdade = false,
                Multiplayer = true,
                Nome = "Dark souls"
            };

            _repository.Setup(x => x.ObterGameById(game.GameId));
            var request = _controller.RemoverGame(game.GameId);

            // Assert
            Assert.IsType<NoContentResult>(request);
        }
    }
}
