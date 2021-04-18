using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game.App.Models
{
    public class GameModel
    {
        public GameModel()
        {
            GameId = Guid.NewGuid();
        }

        [Key]
        public Guid GameId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Multiplayer { get; set; }
        public bool MaiorDeIdade { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
