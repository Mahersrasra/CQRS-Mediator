using domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.ApplicationStore.SQLServer;
using Persistence.F1Team;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        static void Main()
        { }
            public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IF1TeamRepository, F1TeamRepository>();
            return services;
        }
    }
}
