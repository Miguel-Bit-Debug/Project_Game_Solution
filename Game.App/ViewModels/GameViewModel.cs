using Game.App.Models;
using System.Collections.Generic;

namespace Game.App.ViewModels
{
    public class GameViewModel
    {
        public IEnumerable<GameModel> Games { get; set; }
    }
}
