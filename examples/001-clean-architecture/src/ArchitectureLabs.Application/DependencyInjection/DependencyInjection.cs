using ArchitectureLabs.Application.Customers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureLabs.Application.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();

        return services;
    }
}
