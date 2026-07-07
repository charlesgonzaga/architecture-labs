using ArchitectureLabs.Domain.Repositories;
using ArchitectureLabs.Infrastructure.Persistence.Context;
using ArchitectureLabs.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureLabs.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase("ArchitectureLabsDb"));

        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
