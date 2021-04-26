using Chapter.Sync.API.Controllers;
using Game.API.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace Game.Test.GameController.Test
{
    public class GameGetByIdControllerTest
    {
        public Mock<IGameRepository<GameModel>> _gameRepository;
        public GamesController _controller;


        public GameGetByIdControllerTest()
        {
            _gameRepository = new Mock<IGameRepository<GameModel>>();
            _controller = new GamesController(_gameRepository.Object);
        }

        [Fact]
        public void DeveRetornarBadRequest_QuandoGameIdRetornarNull()
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

            var controller = _controller.ObterGameById(game.GameId);
            Assert.IsType<BadRequestResult>(controller);
        }
    }
}
