using ArchitectureLabs.Application.Customers.DTOs;

namespace ArchitectureLabs.Application.Customers.Services;

public interface ICustomerService
{
    Task<CustomerResponse> CreateAsync(
        CreateCustomerRequest request,
        CancellationToken cancellationToken);
}
