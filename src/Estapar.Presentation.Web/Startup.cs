using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Estapar.Application;
using Estapar.Infrastructure.Data;
using Estapar.Infrastructure.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Estapar.Presentation.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostEnvironment env)
        {
            Configuration = configuration;

            //

            string baseDir = env.ContentRootPath;
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(baseDir, "App_Data"));

            var feedDirectoryPath = $"{AppDomain.CurrentDomain.GetData("DataDirectory")}";
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Context

            services.AddDbContextPool<Context>(option =>
                 option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
             );

            // IoC

            InjectorDependency.Register(services);

            // AutoMapper

            services.AddAutoMapper(x => x.AddProfile(new MappingEntities()));

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
