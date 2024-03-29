using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolSystemDataAccessLayer;
using SchoolSystemBusinessLayer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;

namespace SchoolSystemWebAPI
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
            services.AddControllers();
            services.AddDbContext<SchoolDBContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("connection")));

            // region swagger
            IServiceCollection serviceCollections = services.AddSwaggerGen(c =>{ c.SwaggerDoc("v1", new OpenApiInfo {
                    Version = "v1",
                    Title = "SchoolSystemAPI",
                    Description = "School Management system using web api"
                });
            });

            services.AddScoped<ISchoolDAL, SchoolDAL>();
            services.AddScoped<ITeacherDAL, TeacherDAL>();
            services.AddTransient<ISchoolBL, SchoolBL>();
            services.AddTransient<ITeacherBL, TeacherBL>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //TO USE SWAGGER 
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Student API v1");
            });
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           }
        }
    }
