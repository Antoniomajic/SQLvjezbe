using MassageParlor.Data;
using MassageParlor.Models;
using Microsoft.AspNetCore.Mvc;

namespace MassageParlor.Controllers
{
    /// <summary>
    /// Intended for CRUD operations on entity Customer in database
    /// </summary>

    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly MassageParlorContext _context;

        public CustomerController(MassageParlorContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets(pulls) all customers from database 
        /// </summary>
        /// <remarks>
        /// Example query:
        /// 
        ///     GET api/v1/Customer
        /// </remarks>
        /// <returns>Customer in database</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="400">Request is not valid (BadRequest)</response>
        /// <response code="503">Add IP in firewall on azure</response>        
        [HttpGet]
        public IActionResult Get()
        {           
            return new JsonResult(_context.Customer.ToList());
        }

        /// <summary>
        /// Adds customer in database
        /// </summary>
        /// <remarks>
        /// Query example:
        /// 
        ///     POST api/v1/Customer
        ///     {firstname:"name",lastname:"surname"}
        ///     
        /// </remarks>
        /// <returns>Created customer in database with all information</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="400">Request is not valid (BadRequest)</response> 
        /// <response code="503">Add IP in firewall on azure</response> 
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
