using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Product.Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    private static readonly string[] Products = new[]
    {
        "iPhone", "iPad", "MacBook", "MacBookPro",
    };
    public ProductController()
    {
        
    }

    [HttpGet]
    [Authorize]
    [Route("products")]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(Products);
    }
}