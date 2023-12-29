using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
namespace Application
{
    public static class DependencyInjection
    {
        static void Main()
        {
        }
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
