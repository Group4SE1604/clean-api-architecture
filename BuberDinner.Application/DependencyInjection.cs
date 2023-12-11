
using BuberDinner.Application.Persistence;
using BuberDinner.Application.Services.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;

        }

    }
}