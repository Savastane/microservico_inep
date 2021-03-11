using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using inep.domain.entities;
using inep.repository.configuration;
//using infra.generics.repository;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace inep.repository
{
    public class Context :  DbContext
    {


        public DbSet<EscolaEntity> Escola { get; set; }



        public static IConfigurationRoot Configuration { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<EscolaEntity>(new EscolaConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            /*
            optionsBuilder.UseInMemoryDatabase(databaseName: "database_name");
            */

            /*
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var stringcon = Configuration["ConnectionStrings:dbefetivo"];

            bool memory = Convert.ToBoolean(Configuration["DataBase:Memory"]);

            if (memory)
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "database_name");
            }
            else
            {

                optionsBuilder.UseSqlServer(stringcon);
            }
            */

            base.OnConfiguring(optionsBuilder);

        }



    }



}

