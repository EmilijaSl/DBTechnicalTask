using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSchedulingSystem.BL.Extensions
{
    public static class IServiceColectionExtensions
    {
        public static IServiceCollection AddBL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<INotificationService, NotificationService>();
            return services;
        }
    }
}
