using ArchitectureLabs.Application.Commands.CreateCustomer;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ArchitectureLabs.Api.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapPost("/customers", async (CreateCustomerCommand command, ISender sender, CancellationToken cancellationToken) =>
        {
            var id = await sender.Send(command, cancellationToken);
            return Results.CreatedAtRoute("GetCustomer", new { id }, id);
        });
    }
}
