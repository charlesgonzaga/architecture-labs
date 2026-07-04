using FluentAssertions;
using NetArchTest.Rules;

namespace ArchitectureLabs.ArchitectureTests.Layers;

public sealed class ArchitectureTests
{
    [Fact]
    public void Domain_Should_Not_Depend_On_Infrastructure()
    {
        var result = Types
            .InAssembly(typeof(ArchitectureLabs.Domain.Customers.Customer).Assembly)
            .ShouldNot()
            .HaveDependencyOn("ArchitectureLabs.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Domain_Should_Not_Depend_On_Api()
    {
        var result = Types
            .InAssembly(typeof(ArchitectureLabs.Domain.Customers.Customer).Assembly)
            .ShouldNot()
            .HaveDependencyOn("ArchitectureLabs.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Application_Should_Not_Depend_On_Api()
    {
        var result = Types
            .InAssembly(typeof(
                ArchitectureLabs.Application.Customers.Services.ICustomerService)
                .Assembly)
            .ShouldNot()
            .HaveDependencyOn("ArchitectureLabs.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
