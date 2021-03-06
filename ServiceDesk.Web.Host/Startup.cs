﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ServiceDesk.Context.Crashes;
using ServiceDesk.Context.Incidents;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Actions;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Incidents.Service;
using ServiceDesk.Infrastructure.ActionHandler;
using ServiceDesk.Infrastructure.ServiceHandler;
using ServiceDesk.Infrastructure.Validations;
using ServiceDesk.SchemaBuild;
using ServiceDesk.SchemaBuild.Builders;
using ServiceDesk.SchemaBuild.Loaders;
using ServiceDesk.Web.Host.Configure;

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
            services.AddMvc(options => {

            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            // Initialize DI
            services.AddSingleton<ModuleAssembly>();
            services.AddHttpContextAccessor();
            services.AddScoped<SchemaFormsHandler>();
            services.AddScoped<SchemaGridsHandler>();
            services.AddScoped<IFormFieldsBuilder, FormFieldsBuilder>();
            services.AddScoped<IGridBuilder, GridBuilder>();
            services.AddScoped<IServiceHandler<IncidentDto>, CreateIncidentService>();
            services.AddScoped<ContextLoader>();
            services.AddScoped<ModelLoader>();
            

            services.InitializeServiceHandlers();
            services.InitializeServiceQueryHandlers();
            services.InitializeActionHandlers();
            services.InitializeSelector();

            // Initialize automapper
            services.InitializeAutomapper();

            // Initialize contexts
            var connection = Configuration.GetConnectionString("Development");
            services.AddDbContext<IIncidentsQueryableProvider, IncidentsContext>(options => options.UseSqlServer(connection,
                b => b.MigrationsAssembly("ServiceDesk.Context.Incidents")));
            services.AddDbContext<ICrashesQueryableProvider, CrashesContext>(options => options.UseSqlServer(connection,
                b => b.MigrationsAssembly("ServiceDesk.Context.Crashes")));
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
