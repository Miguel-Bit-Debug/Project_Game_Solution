using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Game.App.Models;

namespace Game.App.Data
{
    public class GameAppContext : DbContext
    {
        public GameAppContext (DbContextOptions<GameAppContext> options)
            : base(options)
        {
        }

        public DbSet<Game.App.Models.GameModel> Game{ get; set; }
    }
}
