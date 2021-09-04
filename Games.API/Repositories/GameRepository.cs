using Game.API.Data;
using Game.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Repositories
{
    public class GameRepository : IGameRepository<GameModel>
    {
        private readonly AppDBContext _context;

        public GameRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task AdicionarGame(GameModel game)
        {
            await _context.AddAsync(game);
            _context.SaveChanges();
        }

        public async Task AlterarGame(GameModel game)
        {
            var gameAntigo = _context.Games.FirstOrDefault(g => g.GameId == game.GameId);
            _context.Update(game);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<GameModel> ListarGame()
        {
            return _context.Games;
        }

        public GameModel ObterGameById(Guid id)
        {
            return _context.Games.FirstOrDefault(x => x.GameId == id);
        }

        public async Task RemoverGame(GameModel game)
        {
            _context.Remove(game);
            await _context.SaveChangesAsync();
        }
    }
}
