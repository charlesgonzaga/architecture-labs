using ArchitectureLabs.Domain.Entities;

namespace ArchitectureLabs.Domain.Repositories;

public interface ICustomerRepository
{
    Task AddAsync(Customer customer, CancellationToken cancellationToken = default);
    Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Customer>> GetAllAsync(CancellationToken cancellationToken = default);
}
