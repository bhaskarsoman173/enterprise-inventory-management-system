using EIMS.API.Products.Requests;
using EIMS.Application.Products.Commands.CreateProduct;
using Microsoft.AspNetCore.Mvc;
using CreateProductResponse = EIMS.API.Products.Responses.CreateProductResponse;

namespace EIMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(CreateProductCommandHandler createProductCommandHandler) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductRequest createProductRequest, CancellationToken cancellationToken)
    {
        var result = await createProductCommandHandler.Handle(
            new CreateProductCommand(
                createProductRequest.Name,
                createProductRequest.Description),
            cancellationToken);

        var response = new CreateProductResponse(result.Id);

        return Created(string.Empty, response);
    }
}
