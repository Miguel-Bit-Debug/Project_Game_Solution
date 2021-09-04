using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Game.Library.Models
{
    public class GameBaseModel
    {
        public GameBaseModel()
        {
            GameId = Guid.NewGuid();
        }

        [Key]
        public Guid GameId { get; set; }
    }
}
