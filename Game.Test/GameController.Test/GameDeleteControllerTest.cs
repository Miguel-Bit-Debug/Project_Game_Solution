﻿using Chapter.Sync.API.AppDbContext;
using Chapter.Sync.API.Controllers;
using FluentAssertions;
using Game.API.Models;
using Game.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Game.Test.GameController.Test
{
    public class GameDeleteControllerTest
    {
        public Mock<IGameRepository> _repository;
        public GamesController _controller;
        public AppDBContext _context;

        public GameDeleteControllerTest()
        {
            _repository = new Mock<IGameRepository>();
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
