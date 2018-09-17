using Microsoft.AspNetCore.Mvc;

namespace Pantokrator.Api.Order.Controllers
{
    public class OrderController : Controller
    {
        [Route("~/api/[controller]")]
        [HttpGet]
        public IActionResult Get() => Content("Hi, I'am OrderController");
    }
}