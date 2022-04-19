using Microsoft.Extensions.DependencyInjection;
using Store.Core.Services;
using Store.Presistance.IServices;

namespace Store.Core.Extensions
{
    public static class CoreExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
