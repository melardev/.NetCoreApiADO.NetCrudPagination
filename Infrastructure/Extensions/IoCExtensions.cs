using ApiCoreAdoNetCrudPagination.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCoreAdoNetCrudPagination.Infrastructure.Extensions
{
    public static class IoCExtensions
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ITodoService, TodoService>();
            services.AddTransient<ITodoService, TodoServiceStoredProcedures>();
        }
    }
}