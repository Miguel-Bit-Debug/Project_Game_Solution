using Game.API.Data;
using Game.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Repositories
{
    public class GameRepository<T> : IGenericRepository<GameModel> where T : class
    {
        private readonly AppDBContext _context;

        public GameRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(GameModel game)
        {
            await _context.AddAsync(game);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(GameModel game)
        {
            var gameAntigo = _context.Games.FirstOrDefault(g => g.Id == game.Id);
            _context.Update(game);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<GameModel> List()
        {
            return _context.Games.OrderBy(x => x.Nome);
        }

        public GameModel GetById(Guid id)
        {
            return _context.Games.FirstOrDefault(x => x.Id == id);
        }

        public async Task RemoveAsync(GameModel game)
        {
            _context.Remove(game);
            await _context.SaveChangesAsync();
        }
    }
}
