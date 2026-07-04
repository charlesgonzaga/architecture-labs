using System.Net;
using System.Net.Http.Json;
using ArchitectureLabs.Application.Customers.DTOs;
using FluentAssertions;

namespace ArchitectureLabs.IntegrationTests.Customers;

public sealed class CustomersEndpointsTests
    : IClassFixture<ApiFactory>
{
    private readonly HttpClient _client;

    public CustomersEndpointsTests(ApiFactory factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Should_create_customer()
    {
        var request = new CreateCustomerRequest(
            "Charles Gonzaga",
            "charles@labs.com");

        var response = await _client.PostAsJsonAsync(
            "/api/customers",
            request);

        response.StatusCode.Should()
            .Be(HttpStatusCode.Created);
    }

    [Fact]
    public async Task Should_get_customer_by_id()
    {
        var request = new CreateCustomerRequest(
            "Charles Gonzaga",
            "charles2@labs.com");

        var post = await _client.PostAsJsonAsync(
            "/api/customers",
            request);

        var customer = await post.Content
            .ReadFromJsonAsync<CustomerResponse>();

        var get = await _client.GetAsync(
            $"/api/customers/{customer!.Id}");

        get.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }
}
