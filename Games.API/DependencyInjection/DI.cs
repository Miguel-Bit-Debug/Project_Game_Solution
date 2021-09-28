using Game.API.Repositories;
using Game.Library.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Games.API.DependencyInjection
{
    public static class DI
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<GameModel>), typeof(GameRepository<GameModel>));
            services.AddScoped(typeof(IGenericRepository<ImageModel>), typeof(ImageRepository<ImageModel>));
        }
    }
}
