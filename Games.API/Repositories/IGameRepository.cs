using Game.API.Models;
using System;
using System.Collections.Generic;

namespace Game.API.Repositories
{
    public interface IGameRepository
    {
        void AdicionarGame(GameModel game);
        void AlterarGame(GameModel game);
        IEnumerable<GameModel> ListarGame();
        GameModel ObterGameById(Guid id);
        void RemoverGame(GameModel game);
    }
}
