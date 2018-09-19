using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pantokrator.Core;
using Pantokrator.Core.Model;
using Pantokrator.Data;

namespace Pantokrator.Api.Customer.Controllers
{
    [Produces("application/json")]
    [Route("~/api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly SampleDbContext _context;
        
        public CustomerController(SampleDbContext context)
        {
            _context = context;
            _context.Contacts.RemoveRange(_context.Contacts.ToList());
            _context.SaveChanges();
            _context.GenerateSampleData();
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dataPage = await _context.Contacts.FirstOrDefaultAsync(f => f.Id == id);
            return Ok(dataPage);
        }
        
        [HttpGet]
        public IActionResult Get([FromQuery]PagedBaseApiRequest request)
        {           
            var query = _context.Contacts;
            var dataPage = new PagedList<Contact>(query, request.Page, request.PageSize);
            return Ok(dataPage);
        }
    }
}