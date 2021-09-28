using Game.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Game.API.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<GameModel> Games { get; set; }
        public DbSet<ImageModel> Images { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options) { }
    }
}
