using ArchitectureLabs.Application.Customers.DTOs;
using ArchitectureLabs.Application.Customers.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureLabs.Api.Controllers;

[ApiController]
[Route("api/customers")]
public sealed class CustomersController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomersController(ICustomerService service)
    {
        _service = service;
    }

    [HttpPost]
    [ProducesResponseType<CustomerResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CustomerResponse>> Create(
        [FromBody] CreateCustomerRequest request,
        CancellationToken cancellationToken)
    {
        var customer = await _service.CreateAsync(request, cancellationToken);

        return Created($"/api/customers/{customer.Id}", customer);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType<CustomerResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CustomerResponse>> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var customer = await _service.GetByIdAsync(id, cancellationToken);

        if (customer is null)
            return NotFound();

        return Ok(customer);
    }
}
