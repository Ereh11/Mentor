using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Persistence.UnitOfWork;

namespace Infrastructure.InfraStructureDI
{
    public static class InfraStructureDIRegister
    {
        public static void AddInfraStructureDIRegister(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<UnitOfWork>();
        }
    }
}
