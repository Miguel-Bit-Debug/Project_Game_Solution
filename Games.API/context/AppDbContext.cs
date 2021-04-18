using Game.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Sync.API.AppDbContext
{
    public class AppDBContext : DbContext
    {
        public DbSet<GameModel> Games { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options) { }
    }
}
