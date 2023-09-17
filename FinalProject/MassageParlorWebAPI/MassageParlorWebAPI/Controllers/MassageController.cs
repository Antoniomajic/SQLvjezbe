using MassageParlorWebAPI.Data;
using MassageParlorWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MassageParlorWebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/controller")]
    public class MassageController : ControllerBase
    {
        private readonly MassageParlorContext _context;

        public MassageController(MassageParlorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_context.Massage.ToList());
        }

        [HttpPost]
        public IActionResult Post(Massage massage)
        {
            _context.Massage.Add(massage);
            _context.SaveChanges();
            return Created("/api/v1/massage", massage);
        }

        [HttpPut]
        [Route("{IDs:int}")]
        public IActionResult Put(int ID, Massage massage)
        {
            return StatusCode(StatusCodes.Status200OK, massage);
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
