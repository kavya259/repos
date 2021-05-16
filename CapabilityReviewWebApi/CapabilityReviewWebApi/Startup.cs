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
using StudentBusinessLayer;
using StudentDataAccessLayer;
using StudentEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace CapabilityReviewWebApi
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
            services.AddDbContext<StudentDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("connection")));
            services.AddSwaggerGen(c => {c.SwaggerDoc("v2", new OpenApiInfo { Version = "v2", Title = "Student data" });

                services.AddTransient<IStudentBL, StudentBL>();
                services.AddTransient<IStudentDAL, StudentDAL>();



            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
            if(env.IsDevelopment())
                {
                app.UseDeveloperExceptionPage();
                }
            app.UseSwagger();
            app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v2/swagger.json", "Student manager"); });
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
