using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<PayMeContext>(options =>
                    options.UseNpgsql("enter your postgress conn screen")
            );

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<PayMeContext>());

            return services;
        }
    }
}