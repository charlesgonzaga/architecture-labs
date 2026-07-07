using ArchitectureLabs.Domain.Entities;
using ArchitectureLabs.Domain.Repositories;
using ArchitectureLabs.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureLabs.Infrastructure.Persistence.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Customer customer, CancellationToken cancellationToken = default)
    {
        await _context.Customers.AddAsync(customer, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<IReadOnlyList<Customer>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Customers.ToListAsync(cancellationToken);
    }

    public async Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Customers.FindAsync(new object[] { id }, cancellationToken);
    }
}
