using Game.API.Controllers;
using Game.API.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Game.Test.GameController.Test
{
    public class GameGetControllersTest
    {
        private Mock<IGameRepository<GameModel>> _repository;
        private GamesController _controller;

        public GameGetControllersTest()
        {
            _repository = new Mock<IGameRepository<GameModel>>();
            _controller = new GamesController(_repository.Object);

        }
        [Fact]
        public void DeveRetornarOk_QuandoRequisicaoGet()
        {
            var result = _controller.Index();
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
