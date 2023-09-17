using Microsoft.AspNetCore.Mvc;
using MassageParlorWebAPI.Models;
using MassageParlorWebAPI.Data;

namespace MassageParlorWebAPI.Controllers
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
            // adding to the base
            return Created("/api/v1/customer", customer);
        }

        [HttpPut]
        [Route("{IDs:int}")]
        public IActionResult Put(int ID, Customer customer)
        {
            // editing 
            return StatusCode(StatusCodes.Status200OK, customer);
        }

        [HttpDelete]
        [Route("{IDs:int}")]
        public IActionResult Delete(int ID)
        {
            // deleting 
            return StatusCode(StatusCodes.Status200OK, "{\"obrisano\": true}");
        }



    }
}
