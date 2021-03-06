﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPA_BackREST.DB;
using CPA_BackREST.Repositories;
using CPA_BackREST.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CPA_BackREST
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
            services.AddMvc();
            services.AddTransient<RepositoryFactory>();
            services.AddTransient<DBUtil>();
            services.AddTransient<UserService>();
            services.AddTransient<OfferService>();
            services.AddTransient<EncryptService>();
            services.AddCors();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
                   builder.AllowAnyOrigin().AllowAnyHeader()
               .AllowAnyMethod()
               .AllowAnyHeader());


            app.UseMvc();
        }
    }
}
