using MassageParlor.Data;
using MassageParlor.Models;
using MassageParlor.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MassageParlor.Controllers
{
    /// <summary>
    /// Intended for CRUD operations on entity Massage in database
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MassageController : ControllerBase
    {
        private readonly MassageParlorContext _context;
        public MassageController(MassageParlorContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Gets(pulls) all massages from database 
        /// </summary>
        /// <remarks>
        /// Example query:
        /// 
        ///     GET api/v1/Massage
        /// </remarks>
        /// <returns>Massage in database</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="400">Request is not valid (BadRequest)</response>
        /// <response code="503">Add IP in firewall on azure</response>       
        [HttpGet]
        public IActionResult Get()
        {
            if(!ModelState.IsValid) // in case query is invalid
            {
                return BadRequest(ModelState);
            }

            var massages = _context.Massage.ToList(); // we get massages from database and put them in list massages

            if(massages == null ||  massages.Count == 0)
            {
                return new EmptyResult();
            }

            List<MassageDTO> giveback = new();

            massages.ForEach(m =>
            {
                var mdto = new MassageDTO()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description,
                    Duration = m.Duration,
                    Price = m.Price
                };
                giveback.Add(mdto);
            });
            return Ok(giveback);
        }

        /// <summary>
        /// Adds massages in database
        /// </summary>
        /// <remarks>
        /// Query example:
        /// 
        ///     POST api/v1/Massage
        ///     {name:"name",description:"foot massage"}
        ///     
        /// </remarks>
        /// <returns>Created massage in database with all information</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="400">Request is not valid (BadRequest)</response> 
        /// <response code="503">Add IP in firewall on azure</response> 
        [HttpPost]
        public IActionResult Post(MassageDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }

            try
            {
                Massage m = new Massage()
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Duration = dto.Duration,
                    Price = dto.Price
                };

                _context.Massage.Add(m);
                _context.SaveChanges();
                dto.Id = m.Id;
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);
            }
        }

        /// <summary>
        /// Changes data of existing massage in database
        /// </summary>
        /// <remarks>
        /// Query example:
        ///     PUT api/v1/Massage/1
        /// {
        ///  "id": 0,
        ///  "Name": "string",
        ///  "Description": "string",
        ///  "Duration": "int",
        ///  "Price": "decimal"
        /// }
        /// </remarks>
        /// <param name="id">ID of massage that is being edited</param>
        /// <param name="customer">Name of massage that is being edited</param>
        /// <returns>All sent data of massage</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="204">Massage doesn't exist in database</response>
        /// <response code="415">No JSON</response> 
        /// <response code="503">Add IP in firewall on azure</response> 
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, MassageDTO mdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var massageBase = _context.Massage.Find(id);
                if(massageBase == null)
                {
                    return BadRequest();
                }
                massageBase.Name = mdto.Name;
                massageBase.Description = mdto.Description;
                massageBase.Duration = mdto.Duration;
                massageBase.Price = mdto.Price;

                _context.Massage.Update(massageBase);
                _context.SaveChanges();
                mdto.Id = massageBase.Id;

                return StatusCode(StatusCodes.Status200OK, mdto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);
            }
        }

        /// <summary>
        /// Delete massage from database
        /// </summary>
        /// <remarks>
        /// Query example:
        ///
        ///    DELETE api/v1/massage/1
        ///    
        /// </remarks>
        /// <param name="id">ID of massage that is being deleted</param>  
        /// <returns>Response if massage was deleted or not</returns>
        /// <response code="200">Everything is OK</response>
        /// <response code="204">Massage doesn't exist in database</response>
        /// <response code="415">No JSON</response> 
        /// <response code="503">Add IP in firewall on azure</response> 
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }

            try
            {
                var massageBase = _context.Massage.Find(id);
                if(massageBase == null)
                {
                    return BadRequest();
                }

                _context.Massage.Remove(massageBase);
                _context.SaveChanges();
                return new JsonResult("{\"message\":\"Deleted\"}");
            }
            catch (Exception ex)
            {
                return new JsonResult("{\"message\":\"Can't delete\"}");
            }
        }
    }
}
