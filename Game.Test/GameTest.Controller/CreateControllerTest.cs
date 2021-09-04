using Game.Library.Models;
using Game.API.Repositories;
using Games.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;
using FluentAssertions;

namespace Game.Test.GameTest.Controller
{
    public class CreateControllerTest
    {
        public CreateController _gameController;
        public Mock<IGameRepository<GameModel>> _gameRepository;

        public CreateControllerTest()
        {
            _gameRepository = new Mock<IGameRepository<GameModel>>();
            _gameController = new CreateController(_gameRepository.Object);
        }
        [Fact]
        public void DeveAdicionarGameSuccess()
        {
            var game = new GameModel()
            {
                Nome = "Dark souls",
                Descricao = "Foda",
                MaiorDeIdade = false,
                DataLancamento = DateTime.Now,
                Multiplayer = true
            };
            var controller = _gameController.Create(game);
            Assert.IsType<CreatedResult>(controller);
        }
    }
}
