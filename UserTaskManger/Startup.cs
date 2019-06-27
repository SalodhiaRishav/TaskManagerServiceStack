﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using DAL.Database;
using DAL.Interfaces;
using BAL;
using BAL.Interfaces;
using DAL.Repository;
using DAL;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using ServiceStack;

using Funq;
using UserTaskManger.ServiceInterface;

namespace UserTaskManger
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowMyOrigin",
                builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials().Build());
            });
            services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));          
            services.AddTransient<IDatabaseAutomapperConfiguration, DatabaseAutomapperConfiguration>();
            services.AddTransient<ITaskRepository,TaskRepository>();
            services.AddTransient<ITaskBusinessLogic, TaskBusinessLogic>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserBusinessLogic, UserBusinessLogic>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("AllowMyOrigin");
            app.UseHttpsRedirection();
            app.UseServiceStack(new AppHost
            {
                AppSettings = new NetCoreAppSettings(Configuration)
            });
           // app.UseMvc();
        }
    }

    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("UserTaskManager", typeof(MyServices).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            SetConfig(new HostConfig
            {
                DefaultRedirectPath = "/metadata",
                DebugMode = AppSettings.Get(nameof(HostConfig.DebugMode), false)
            });
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());
        }
    }
}
