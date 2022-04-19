using Microsoft.Extensions.DependencyInjection;
using Store.Identity.IServices;
using Store.Identity.Services;

namespace Store.Identity.Extensions
{
    public static class IdentityExtensions
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
