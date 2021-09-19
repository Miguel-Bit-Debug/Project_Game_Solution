using System;
using System.ComponentModel.DataAnnotations;

namespace Game.Library.Models
{
    public class GameModel : GameBaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Multiplayer { get; set; }
        public bool MaiorDeIdade { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
