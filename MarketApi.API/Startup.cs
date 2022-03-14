using MarketApi.Application.services;
using MarketApi.Domain.repositories;
using MarketApi.Persistance.EF.contexts;
using MarketApi.Persistance.EF.repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketApi.API
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MarketApi.API", Version = "v1" });
            });
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("LocalDb"));
            });
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<ICampaingRepository, EFCampaignRepository>();
            services.AddScoped<ICampaignProductRepository, EFCampaignProductRepository>();
            services.AddScoped<IAddProductService, AddProductService>();
            services.AddScoped<ICreateCampaignService, CreateCampaignService>();
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyMethod(); // GET,POST apida açýk, HTTPDELETE, HTTPUT içinde açmýþ olduk; 415 hatasýda HttpMethod izni verilmemiþtir.
                    policy.AllowAnyOrigin(); // Herhangi bir domaine istek atabiliriz.
                    //policy.WithOrigins("www.a.com", "www.b.com");
                    policy.AllowAnyHeader(); // Application/json appliation/xml
                    //policy.WithHeaders("x-token"); // Application/json appliation/xml
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MarketApi.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //     app.UseEndpoints(endpoints =>
            //     {
            //         endpoints.MapControllerRoute(
            //name: "default",
            //pattern: "{controller=Home}/{action=Index}/{id?}");
            //         endpoints.MapControllers();
            //     });
        }
    }
}
