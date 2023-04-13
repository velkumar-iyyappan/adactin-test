using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services )
        {
            services.AddDbContext<RepositoryContext>(ServiceLifetime.Scoped);           
            services.AddScoped<IUnitOfWork, UnitOfWork>();            
            services.AddScoped<IOccupationRepository, OccupationRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();

            return services;
        }
    }
}
