using System.Net.Mail;
using ArchitectureLabs.Domain.Abstractions;
using ArchitectureLabs.Domain.Exceptions;

namespace ArchitectureLabs.Domain.Customers;

public sealed class Customer : AggregateRoot<CustomerId>
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    private Customer()
    {
        Name = string.Empty;
        Email = string.Empty;
    }

    private Customer(CustomerId id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public static Customer Create(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new DomainException(CustomerErrors.NameRequired);
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new DomainException(CustomerErrors.EmailRequired);
        }

        if (!IsValidEmail(email))
        {
            throw new DomainException(CustomerErrors.InvalidEmail);
        }

        return new Customer(
            CustomerId.New(),
            name.Trim(),
            email.Trim().ToLowerInvariant());
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            _ = new MailAddress(email);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
