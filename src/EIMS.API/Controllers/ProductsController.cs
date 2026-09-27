using EIMS.API.Products.Requests;
using EIMS.API.Products.Responses;
using EIMS.Application.Products.Commands.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace EIMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateProducts(CreateProductRequest createProductRequest)
    {


        return Created();
    }
}
