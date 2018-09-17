using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pantokrator.Data;

namespace Pantokrator.Api.Customer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly SampleDbContext _context;

        public CustomerController(SampleDbContext context)
        {
            _context = context;
            _context.GenerateSampleData();
        }

        [Route("~/api/[controller]")]
        [HttpGet]
        public IList<Contact> Get()
        {
            var dataPage = _context.Contacts.ToList();
            return dataPage;
        }
    }
}