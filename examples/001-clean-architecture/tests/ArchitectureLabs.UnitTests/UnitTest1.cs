using ArchitectureLabs.Domain.Customers;

namespace ArchitectureLabs.UnitTests;

public class CustomerIdTests
{
    [Fact]
    public void Create_ShouldPreserveGuidValue()
    {
        var guid = Guid.NewGuid();

        var id = CustomerId.Create(guid);

        Assert.Equal(guid, id.Value);
    }

    [Fact]
    public void New_ShouldCreateDifferentIds()
    {
        var first = CustomerId.New();
        var second = CustomerId.New();

        Assert.NotEqual(first.Value, second.Value);
    }

    [Fact]
    public void SameValue_ShouldBeEqual()
    {
        var guid = Guid.NewGuid();
        var first = CustomerId.Create(guid);
        var second = CustomerId.Create(guid);

        Assert.Equal(first, second);
        Assert.True(first == second);
    }

    [Fact]
    public void ToString_ShouldReturnGuidString()
    {
        var guid = Guid.Parse("00000000-0000-0000-0000-000000000001");
        var id = CustomerId.Create(guid);

        Assert.Equal(guid.ToString(), id.ToString());
    }
}