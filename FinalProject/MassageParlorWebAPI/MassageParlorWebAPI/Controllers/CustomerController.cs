using Microsoft.AspNetCore.Mvc;
using MassageParlorWebAPI.Models;

namespace MassageParlorWebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var lista = new List<Customer>()
            {
                new (){FirstName = "Marija", LastName = "Marić", Contact = "199-151456-13"},
                new (){FirstName = "Mirko", LastName = "Mirkić", Contact = "mirko.mirkic@gmail.com"}
            };
            return new JsonResult(lista);
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            // adding to the base
            return Created("/api/v1/customer", customer);
        }

        [HttpPut]
        [Route("{IDs:int}")]
        public IActionResult Put(int IDs, Customer customer)
        {
            // editing 
            return StatusCode(StatusCodes.Status200OK, customer);
        }

        [HttpDelete]
        [Route("{IDs:int}")]
        public IActionResult Delete(int IDs)
        {
            // deleting 
            return StatusCode(StatusCodes.Status200OK, true);
        }



    }
}
