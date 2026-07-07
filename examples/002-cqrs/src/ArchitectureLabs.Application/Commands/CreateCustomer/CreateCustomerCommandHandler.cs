using ArchitectureLabs.Domain.Entities;
using ArchitectureLabs.Domain.Repositories;
using MediatR;

namespace ArchitectureLabs.Application.Commands.CreateCustomer;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
{
    private readonly ICustomerRepository _repository;

    public CreateCustomerCommandHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            CreatedAt = DateTime.UtcNow
        };

        await _repository.AddAsync(customer, cancellationToken);

        return customer.Id;
    }
}
