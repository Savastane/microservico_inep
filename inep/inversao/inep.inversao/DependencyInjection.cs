using inep.application;
using inep.application.Commands;
using inep.domain.interfaces;
using inep.repository;
using inep.repository.raven;
//using inep.repository.Repository;
using MediatR;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace inep.inversao
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddRavenDbDocStore() // 1. Configures Raven connection using the settings in appsettings.json.
                    .AddRavenDbAsyncSession(); // 2. Add a scoped IAsyncDocumentSession. For the sync version, use .AddRavenSession() instead.

            services.AddMediatR(typeof(CriarEscolaRequest).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(EditarEscolaIdentificacaoRequest).GetTypeInfo().Assembly);

            services.AddScoped<IEscolaRepository, EscolaRepository>();
            services.AddScoped<ISistemaRepository, SistemaRepository>();


            return services;
        }
    }






    //public static class OldDependencyInjection
    //{


    // services.AddDatabaseDeveloperPageExceptionFilter();
    //services.AddScoped<IEscolaService, EscolaService>();
    //services.AddMediatR(typeof(EditarEscolaCommand));
    //services.AddSingleton<IDocumentStoreHolder, DocumentStoreHolder>();


    //    //public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
    //    //{
    //    //    //services.AddDbContext<Context>(options => options.UseSqlServer(configuration.GetConnectionString(""), b => b.MigrationsAssembly(typeof(Context).Assembly.FullName)));

    //    //    // services.AddDatabaseDeveloperPageExceptionFilter();
    //    //    //services.AddScoped<IEscolaRepository, EscolaRepository>();
    //    //    //services.AddScoped<IEscolaService, EscolaService>();

    //    //    return services;
    //    //}
    //}


}

