using Estapar.Application;
using Estapar.Domain;
using Estapar.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Infrastructure.IoC
{
    public class InjectorDependency
    {
        public static void Register(IServiceCollection container)
        {
            // Application

            container.AddScoped(typeof(IBaseAppService<>), typeof(BaseAppService<>));
            container.AddScoped<ICarroAppService, CarroAppService>();
            container.AddScoped<IManobristaAppService, ManobristaAppService>();
            container.AddScoped<ICarroManobristaAppService, CarroManobristaAppService>();

            // Domain

            container.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            container.AddScoped<ICarroService, CarroService>();
            container.AddScoped<IManobristaService, ManobristaService>();
            container.AddScoped<ICarroManobristaService, CarroManobristaService>();

            // Infrastructure

            container.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            container.AddScoped<ICarroRepository, CarroRepository>();
            container.AddScoped<IManobristaRepository, ManobristaRepository>();
            container.AddScoped<ICarroManobristaRepository, CarroManobristaRepository>();
        }
    }
}
