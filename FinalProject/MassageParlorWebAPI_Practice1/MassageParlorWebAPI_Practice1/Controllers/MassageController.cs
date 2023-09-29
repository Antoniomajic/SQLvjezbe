using MassageParlorWebAPI_Practice1.Data;
using MassageParlorWebAPI_Practice1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MassageParlorWebAPI_Practice1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MassageController : ControllerBase
    {
        private readonly MassageParlorContext _context;

        public MassageController(MassageParlorContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get() // IAction will give me list of Massages in Json format (Of course, we do that in Get)
        {            
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var massages = _context.Massage.ToList();
                if(massages == null || massages.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(_context.Massage.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post(Massage massage) // receives Json from Massage
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest(ModelState); 
            }

            try
            {
                _context.Massage.Add(massage);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, massage);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
        }


        [HttpPut]
        [Route("{id:int}")] // we have to have id, because we edit by it
        public IActionResult Put(int id, Massage massage)
        {
            if(id<=0 || massage == null)
            {
                return BadRequest();
            }

            try
            {
                var massageDB = _context.Massage.Find(id);
                if(massageDB == null)
                {
                    return BadRequest();
                }

                // usually we would do mappers, but for know it's all by hand
                massageDB.Name= massage.Name;
                massageDB.Duration= massage.Duration;   
                massageDB.Description= massage.Description;
                massageDB.Price= massage.Price;

                _context.Massage.Update(massageDB);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, massageDB);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
        }


        [HttpDelete]
        [Route("{id:int}")] // we need id by which we will delete, but we don't need Massage
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            try
            {
                var massageDB = _context.Massage.Find(id);
                if( massageDB == null)
                {
                    return BadRequest();
                }
                
                _context.Massage.Remove(massageDB);
                _context.SaveChanges();

                return new JsonResult("{\"message\":\"Deleted\"}");
            }
            catch (Exception ex)
            {
                try
                {
                    SqlException sqle=(SqlException)ex;
                    return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
                }
                catch (Exception e)
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
                }
            }
        }




    }  
}
