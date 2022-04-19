using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Models.IRepository;
using Store.Models.IUnitofWork;
using Store.Presistance.Data;
using Store.Presistance.Repository;

namespace Store.Presistance.Extensions
{
    public static class PresistanceExtensions
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<StoreContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
    }
}
