using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ServiceDesk.Crashes.Context;
using ServiceDesk.Incidents.Context;
using ServiceDesk.Infrastructure.Context;
using ServiceDesk.SchemaBuild;

namespace ServiceDesk.Web.Host
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<ModuleAssembly>();

            var connection = Configuration.GetConnectionString("Development");
            services.AddDbContext<IIncidentsQueryableProvider, IncidentsContext>(options => options.UseSqlServer(connection,
                b => b.MigrationsAssembly("ServiceDesk.Incidents.Context")));
            services.AddDbContext<ICrashesQueryableProvider, CrashesContext>(options => options.UseSqlServer(connection,
                b => b.MigrationsAssembly("ServiceDesk.Crashes.Context")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
