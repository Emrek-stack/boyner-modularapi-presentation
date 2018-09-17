using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Pantokrator.Data
{
    public static class DataModuleLoader
    {
        public static IServiceCollection AddDataModule(this IServiceCollection services)
        {
            services.AddDbContext<SampleDbContext>(o => o.UseInMemoryDatabase());
            return services;
        }
    }
}