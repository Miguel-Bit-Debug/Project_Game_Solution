using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.API.Repositories
{
    public interface IGameRepository<T> where T : class
    {
        Task AdicionarGame(T game);
        Task AlterarGame(T game);
        IEnumerable<T> ListarGame();
        T ObterGameById(Guid id);
        Task RemoverGame(T game);
    }
}
