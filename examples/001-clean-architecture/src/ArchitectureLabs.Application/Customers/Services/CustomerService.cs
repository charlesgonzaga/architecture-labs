using ArchitectureLabs.Application.Customers.DTOs;
using ArchitectureLabs.Domain.Customers;

namespace ArchitectureLabs.Application.Customers.Services;

public sealed class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task<CustomerResponse> CreateAsync(
        CreateCustomerRequest request,
        CancellationToken cancellationToken)
    {
        var exists = await _repository.ExistsByEmailAsync(
            request.Email,
            cancellationToken);

        if (exists)
            throw new InvalidOperationException("Email já existe.");

        var customer = Customer.Create(
            request.Name,
            request.Email);

        await _repository.AddAsync(customer, cancellationToken);

        return new CustomerResponse(
            customer.Id.Value,
            customer.Name,
            customer.Email);
    }

    public async Task<CustomerResponse?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken)
    {
        var customer = await _repository.GetByIdAsync(
            CustomerId.Create(id),
            cancellationToken);

        if (customer is null)
            return null;

        return new CustomerResponse(
            customer.Id.Value,
            customer.Name,
            customer.Email);
    }
}
