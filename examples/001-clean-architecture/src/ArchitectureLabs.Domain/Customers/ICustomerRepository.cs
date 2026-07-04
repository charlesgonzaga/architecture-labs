namespace ArchitectureLabs.Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(
        CustomerId id,
        CancellationToken cancellationToken = default);

    Task<bool> ExistsByEmailAsync(
        string email,
        CancellationToken cancellationToken = default);

    Task AddAsync(
        Customer customer,
        CancellationToken cancellationToken = default);
}
