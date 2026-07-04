using ArchitectureLabs.Domain.Customers;
using ArchitectureLabs.Domain.Exceptions;

namespace ArchitectureLabs.UnitTests.Customers;

public class CustomerTests
{
    [Fact]
    public void Create_ShouldCreateValidCustomer()
    {
        var customer = Customer.Create("Charles Gonzaga", "charles@email.com");

        Assert.NotNull(customer);
        Assert.Equal("Charles Gonzaga", customer.Name);
        Assert.Equal("charles@email.com", customer.Email);
        Assert.NotEqual(Guid.Empty, customer.Id.Value);
    }

    [Fact]
    public void Create_ShouldThrowException_WhenNameIsEmpty()
    {
        var exception = Assert.Throws<DomainException>(() => Customer.Create("   ", "charles@email.com"));

        Assert.Equal(CustomerErrors.NameRequired, exception.Message);
    }

    [Fact]
    public void Create_ShouldThrowException_WhenEmailIsEmpty()
    {
        var exception = Assert.Throws<DomainException>(() => Customer.Create("Charles Gonzaga", "   "));

        Assert.Equal(CustomerErrors.EmailRequired, exception.Message);
    }

    [Fact]
    public void Create_ShouldThrowException_WhenEmailIsInvalid()
    {
        var exception = Assert.Throws<DomainException>(() => Customer.Create("Charles Gonzaga", "invalid-email"));

        Assert.Equal(CustomerErrors.InvalidEmail, exception.Message);
    }

    [Fact]
    public void Create_ShouldNormalizeEmailToLowercase()
    {
        var customer = Customer.Create("Charles Gonzaga", "CHARLES@EMAIL.COM");

        Assert.Equal("charles@email.com", customer.Email);
    }

    [Fact]
    public void Create_ShouldTrimNameWhitespace()
    {
        var customer = Customer.Create("  Charles Gonzaga  ", "charles@email.com");

        Assert.Equal("Charles Gonzaga", customer.Name);
    }
}
