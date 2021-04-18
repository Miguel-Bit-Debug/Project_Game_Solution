using Chapter.Sync.API.Controllers;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Game.Test.GameController.Test
{
    public class GameGetControllersTest
    {
        private Mock<IGameRepository> _repository;
        private GamesController _controller;

        public GameGetControllersTest()
        {
            _repository = new Mock<IGameRepository>();
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
