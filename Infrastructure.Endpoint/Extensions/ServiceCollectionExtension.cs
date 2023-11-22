using Domain.Endpoint.Interfaces.Repositories;
using Infrastructure.Endpoint.Data;
using Infrastructure.Endpoint.Data.Repositories;
using Infrastructure.Endpoint.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Endpoint.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {

            services.AddScoped<IProveedorRepository, ProveedorRepository>();
            services.AddScoped<IUserRepository, UserResopitory>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICatProductoRepository, CatProductoRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            //services.AddScoped<IEntitiesService, EntitiesService>();
            services.AddSingleton<ISqlDbConnection>(SqlDbConnection.GetInstance());
            return services;
        }
    }
}
