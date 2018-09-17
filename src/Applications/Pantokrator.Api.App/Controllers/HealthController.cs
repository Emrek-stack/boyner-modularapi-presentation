using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Pantokrator.Api.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly ApplicationPartManager _applicationPartManager;
        
        public HealthController(ApplicationPartManager applicationPartManager)
        {
            _applicationPartManager = applicationPartManager;        
        }

        [HttpGet]
        [HttpGet]
        public IActionResult Get()
        {
            List<AssemblyPart> model = _applicationPartManager.ApplicationParts.Cast<AssemblyPart>()
                .Where(w => w.Name.StartsWith("Pantokrator")).ToList();
            return Ok(model.Select(s => s.Name));
        }
    }
}