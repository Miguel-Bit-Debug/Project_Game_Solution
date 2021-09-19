using Game.API.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Games.API.DependencyInjection
{
    public static class DI
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGameRepository<>), typeof(GameRepository<>));
        }
    }
}
