using Microsoft.AspNetCore.Mvc;

namespace Pantokrator.Api.Product.V2.Controllers
{
    public class ProductController : Controller
    {
        [Route("~/api/v2/[controller]")]
        [HttpGet]
        public IActionResult Get() => Content("Hi, I'am ProductController V2");
    }
}