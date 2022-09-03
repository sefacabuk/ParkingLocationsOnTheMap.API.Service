using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ParkingLocationsOnTheMap.Business.Abstract;
using ParkingLocationsOnTheMap.Business.Concrete;
using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.API
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

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ParkingLocationsOnTheMap.API", Version = "v1" });
            });

            services.AddSingleton<IIsparkDataService, IsparkDataManager>();
            services.AddSingleton<IIsparkDataRepository, IsparkDataRepository>();

            services.AddSingleton<INewIsparkDataService, NewIsparkDataManager>();
            services.AddSingleton<INewIsparkDataRepository, NewIsparkDataRepository>();

            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserRepository, UserRepository>();

            services.AddSingleton<IUserAccessService, UserAccessManager>();
            services.AddSingleton<IUserAccessRepository, UserAccessRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ParkingLocationsOnTheMap.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
