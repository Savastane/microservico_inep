using inep.application;
using inep.domain.interfaces;
using inep.repository;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.inversao
{
    public static class OldDependencyInjection
    {
        //public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        //{
        //    //services.AddDbContext<Context>(options => options.UseSqlServer(configuration.GetConnectionString(""), b => b.MigrationsAssembly(typeof(Context).Assembly.FullName)));

        //    // services.AddDatabaseDeveloperPageExceptionFilter();
        //    //services.AddScoped<IEscolaRepository, EscolaRepository>();
        //    //services.AddScoped<IEscolaService, EscolaService>();

        //    return services;
        //}
    }
}
