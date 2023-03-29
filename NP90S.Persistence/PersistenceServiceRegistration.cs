using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NP90S.Application.Models.Album;

namespace NP90S.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AlbumMongoContextOption>(configuration.GetSection("DatabaseSettings"));

            return services;
        }
    }
}
