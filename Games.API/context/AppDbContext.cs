using Game.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Game.API.AppDbContext
{
    public class AppDBContext : DbContext
    {
        public DbSet<GameModel> Games { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options) { }
    }
}
