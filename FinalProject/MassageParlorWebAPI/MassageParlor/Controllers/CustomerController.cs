using MassageParlor.Data;
using MassageParlor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var customers = _context.Customer.ToList();
                if(customers == null || customers.Count == 0 )
                {
                    return new EmptyResult();
                }
                return new JsonResult(_context.Customer.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message); 
            }
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetBySifra(int id)
        {
            if(id <= 0)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var s = _context.Customer.Find(id);

                if (s == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent, s);
                }
                return new JsonResult(s);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
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
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _context.Customer.Add(customer);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, customer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
        }


        /// <summary>
        /// Changes data of existing Customer in database
        /// </summary>
        /// <remarks>
        /// Query example:
        ///     PUT api/v1/Customer/1
        /// {
        ///  "id": 0,
        ///  "firstName": "string",
        ///  "lastName": "string",
        ///  "contact": "string"
        /// }
        /// </remarks>
        /// <param name="id">ID of customer that is being edited</param>
        /// <param name="customer">Name of customer that is being edited</param>
        /// <returns>All sent data of customer</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="204">Customer doesn't exist in database</response>
        /// <response code="415">No JSON</response> 
        /// <response code="503">Add IP in firewall on azure</response> 
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, Customer customer)
        {
            if(id <= 0 || customer == null)
            {
                return BadRequest();
            }

            try
            {
                var customerBase = _context.Customer.Find(id);
                if(customerBase == null)
                {
                    return BadRequest();
                }
                customerBase.FirstName = customer.FirstName;
                customerBase.LastName = customer.LastName;
                customerBase.Contact = customer.Contact;

                _context.Customer.Update(customerBase);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, customerBase);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }

        }

        /// <summary>
        /// Delete Customer from database
        /// </summary>
        /// <remarks>
        /// Query example:
        ///
        ///    DELETE api/v1/customer/1
        ///    
        /// </remarks>
        /// <param name="id">ID of customer that is being deleted</param>  
        /// <returns>Response if customer was deleted or not</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="204">Customer doesn't exist in database</response>
        /// <response code="415">No JSON</response> 
        /// <response code="503">Add IP in firewall on azure</response> 
        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]            
        public IActionResult Delete(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            try
            {
                var customerBase = _context.Customer.Find(id);
                if (customerBase == null)
                {
                    return BadRequest();
                }

                _context.Customer.Remove(customerBase);
                _context.SaveChanges();

                return new JsonResult("\"message\":\"Deleted\"}");
            }
            catch (Exception ex)
            {
                return new JsonResult("{\"message\":\"Can't delete\"}");
            }

            
        }
    }
}
