using ArchitectureLabs.Domain.Customers;
using ArchitectureLabs.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureLabs.Infrastructure.Repositories;

public sealed class CustomerRepository
    : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(
        ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Customer?> GetByIdAsync(
        CustomerId id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Customers
            .FirstOrDefaultAsync(
                x => x.Id == id,
                cancellationToken);
    }

    public async Task<bool> ExistsByEmailAsync(
        string email,
        CancellationToken cancellationToken = default)
    {
        return await _context.Customers
            .AnyAsync(
                x => x.Email == email,
                cancellationToken);
    }

    public async Task AddAsync(
        Customer customer,
        CancellationToken cancellationToken = default)
    {
        await _context.Customers.AddAsync(
            customer,
            cancellationToken);

        await _context.SaveChangesAsync(
            cancellationToken);
    }
}
