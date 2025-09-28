using Desafio.Application.Interfaces;
using Desafio.Application.Services;
using Desafio.Data.Repositories;
using Desafio.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection _service)
        {
            _service.AddScoped<ITituloService, TituloService>();


            _service.AddScoped<ITituloRepository, TituloRepository>();
        }
    }
}
