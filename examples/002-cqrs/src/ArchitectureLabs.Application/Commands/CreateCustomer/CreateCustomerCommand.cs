using MediatR;

namespace ArchitectureLabs.Application.Commands.CreateCustomer;

public class CreateCustomerCommand : IRequest<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
