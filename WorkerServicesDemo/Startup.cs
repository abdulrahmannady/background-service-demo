using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerServicesDemo
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            Conf.LLBLGen(_config);

            services.AddHostedService<ClearTableService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
    public class Conf
    {
        public static void LLBLGen(IConfiguration config)
        {
            RuntimeConfiguration.AddConnectionString("ConnectionString.PostgreSql (Npgsql)", config["connectionString"]);
            RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(c =>
            {
                c.AddDbProviderFactory(typeof(Npgsql.NpgsqlFactory));
                c.SetTraceLevel(TraceLevel.Verbose);
            });
        }
    }
}
