using Microsoft.AspNetCore.Mvc;

namespace Pantokrator.Api.Payment.Controllers
{
    public class PaymentController : Controller
    {
        [Route("~/api/[controller]")]
        [HttpGet]
        public IActionResult Get() => Content("Hi, I'am PaymentController");
    }
}