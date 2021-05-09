using Game.API.Data;
using Game.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.API.Repositories
{
    public class GameRepository : IGameRepository<GameModel>
    {
        private readonly AppDBContext _context;

        public GameRepository(AppDBContext context)
        {
            _context = context;
        }
        public void AdicionarGame(GameModel game)
        {
            _context.Add(game);
            _context.SaveChanges();
        }

        public void AlterarGame(GameModel game)
        {
            var gameAntigo = _context.Games.FirstOrDefault(g => g.GameId == game.GameId);
            _context.Update(game);
            _context.SaveChanges();
        }

        public IEnumerable<GameModel> ListarGame()
        {
            return _context.Games;
        }

        public GameModel ObterGameById(Guid id)
        {
            return _context.Games.FirstOrDefault(x => x.GameId == id);
        }

        public void RemoverGame(GameModel game)
        {
            _context.Remove(game);
            _context.SaveChanges();
        }
    }
}
