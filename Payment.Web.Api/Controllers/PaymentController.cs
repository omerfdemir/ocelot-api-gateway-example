using Microsoft.AspNetCore.Mvc;

namespace Payment.Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PaymentController: ControllerBase
{
    private static readonly string[] PaymentMethods = new[]
    {
        "CreditCard", "Cash", "Apple Pay",
    };
    public PaymentController()
    {
        
    }

    [HttpGet]
    [Route("payment-methods")]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(PaymentMethods);
    }
}