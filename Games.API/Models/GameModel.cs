using System;
using System.ComponentModel.DataAnnotations;

namespace Game.API.Models
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
