using ArchitectureLabs.Domain.Customers;
using ArchitectureLabs.Infrastructure.Persistence;
using ArchitectureLabs.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureLabs.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(
            options =>
                options.UseNpgsql(
                    configuration.GetConnectionString(
                        "DefaultConnection")));

        services.AddScoped<
            ICustomerRepository,
            CustomerRepository>();

        return services;
    }
}
