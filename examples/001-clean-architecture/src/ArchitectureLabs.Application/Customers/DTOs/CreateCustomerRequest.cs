namespace ArchitectureLabs.Application.Customers.DTOs;

public sealed record CreateCustomerRequest(
    string Name,
    string Email);
