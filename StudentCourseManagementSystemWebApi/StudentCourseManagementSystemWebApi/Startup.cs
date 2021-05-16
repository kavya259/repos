using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentCourseManagementEntities;
using StudentCourseManagementDataAccessLayer;
using StudentCourseManagentBusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace StudentCourseManagementSystemWebApi
    {
    public class Startup
        {
        public Startup(IConfiguration configuration)
            {
            Configuration = configuration;
            }

        public IConfiguration Configuration
            {
            get;
            }

        // This method gets called by the runtime. Use this method to add services to the container.


        public void ConfigureServices(IServiceCollection services)
            {
            services.AddControllers();
            services.AddMvc();
            services.AddDbContext<StudentManagementDBContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("connection")));




            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                    {
                    Version = "v1",
                    Title = "Actors Management System",

                    });
            });
            services.AddTransient<IStudentManagementBL, StudentManagementBL>();
            services.AddTransient<IStudentManagementDAL, StudentManagementDAL>();


            }


       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
            if(env.IsDevelopment())
                {
                app.UseDeveloperExceptionPage();
                }
            app.UseSwagger();
            app.UseSwaggerUI(x => 
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Document v1"); }
            );

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
