using ArchitectureLabs.Application.Customers.DTOs;

namespace ArchitectureLabs.Application.Customers.Services;

public interface ICustomerService
{
    Task<CustomerResponse> CreateAsync(
        CreateCustomerRequest request,
        CancellationToken cancellationToken);

    Task<CustomerResponse?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken);
}
