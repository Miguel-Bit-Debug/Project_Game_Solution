using System;
using System.Collections.Generic;

namespace Game.API.Repositories
{
    public interface IGameRepository<T>
    {
        void AdicionarGame(T game);
        void AlterarGame(T game);
        IEnumerable<T> ListarGame();
        T ObterGameById(Guid id);
        void RemoverGame(T game);
    }
}
