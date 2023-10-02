using MassageParlor.Data;
using MassageParlor.Models;
using Microsoft.AspNetCore.Mvc;

namespace MassageParlor.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly MassageParlorContext _context;

        public CustomerController(MassageParlorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {           
            return new JsonResult(_context.Customer.ToList());
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return Created("api/v1/Customer", customer);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, Customer customer)
        {
            return StatusCode(StatusCodes.Status200OK, customer);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            return StatusCode(StatusCodes.Status200OK, "{\"deleted\":true}");
        }
    }
}
