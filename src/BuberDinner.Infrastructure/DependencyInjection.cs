using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Interfaces.Auth;
using BuberDinner.Application.Common.Services;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Application.Persistence;
using BuberDinner.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BuberDinner.Application.Services.Menu;
using BuberDinner.Infrastructure.Services.Menu;

namespace BuberDinner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {

            services.AddSingleton<IJwtGenerator, JwtGenrator>();
            services.AddSingleton<IDatetimeProivder, DatetimeProvider>();
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IMenuItemRepository, MenuItemRepository>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuItemService, MenuItemService>();

            return services;
        }

    }
}