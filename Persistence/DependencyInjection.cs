// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.ApplicationStore.SQLServer;
using Persistence.F1Team;

public static class DependencyInjection
{
    static void Main()
    { }
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<F1TeamDbContextSQLServer>(DbContextOptionsBuilder =>
        {
            var connectionstring = "Your sql server connection string";
            DbContextOptionsBuilder.UseSqlServer(connectionstring);
        });
        return services;
    }
}