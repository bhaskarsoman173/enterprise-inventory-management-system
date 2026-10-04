using EIMS.Application.Abstractions.Persistence;
using EIMS.Application.Products.Repositories;
using EIMS.Infrastructure.Persistence;
using EIMS.Infrastructure.Persistence.Repositories;
using EIMS.Infrastructure.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EIMS.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options
            => options.UseSqlServer(configuration.GetConnectionString("EimsDatabase")));
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
