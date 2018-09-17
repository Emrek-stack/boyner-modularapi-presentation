using Microsoft.AspNetCore.Mvc;

namespace Pantokrator.Api.Product.V1.Controllers
{
    public class ProductController : Controller
    {

        [Route("~/api/v1/[controller]")] 
        [HttpGet]
        public IActionResult Get() => Content("Hi, I'am ProductController V1");
    }
}