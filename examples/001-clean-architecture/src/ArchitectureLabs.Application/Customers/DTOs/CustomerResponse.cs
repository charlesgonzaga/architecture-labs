namespace ArchitectureLabs.Application.Customers.DTOs;

public sealed record CustomerResponse(
    Guid Id,
    string Name,
    string Email);
