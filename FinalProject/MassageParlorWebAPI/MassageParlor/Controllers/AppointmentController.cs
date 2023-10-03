using MassageParlor.Data;
using MassageParlor.Models;
using MassageParlor.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MassageParlor.Controllers
{
    /// <summary>
    /// Intended for CRUD operations on entity Appointment in database
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly MassageParlorContext _context;
        private readonly ILogger<AppointmentController> _logger; // for purpose of logging

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name ="context"></param>        
        public AppointmentController(MassageParlorContext context, ILogger<AppointmentController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Retrieving appointments");
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var appointments = _context.Appointment.Include(a => a.Customer).Include(a => a.Massages).ToList();
                if(appointments == null || appointments.Count == 0)
                {
                    return new EmptyResult();
                }

                List<AppointmentDTO> giveback = new();
                appointments.ForEach(a =>
                {
                    giveback.Add(new AppointmentDTO
                    {
                        Id = a.Id,
                        DateAndTime = a.DateAndTime,
                        Customer = a.Customer?.FirstName + " " + a.Customer?.LastName,
                        MassageNumber = a.Massages.Count,
                        IdCustomer = a.Customer.Id
                    });
                });
                return Ok(giveback);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);
            }
        }


        [HttpPost]
        public IActionResult Post(AppointmentDTO appointmentDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(appointmentDTO.IdCustomer <= 0)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var customer = _context.Customer.Find(appointmentDTO.IdCustomer);
                if(customer == null)
                {
                    return BadRequest(ModelState);
                }

                Appointment a = new()
                {
                    DateAndTime = appointmentDTO.DateAndTime,
                    Customer = customer
                };

                _context.Appointment.Add(a);
                _context.SaveChanges();

                appointmentDTO.Id = a.Id;
                appointmentDTO.Customer = customer.FirstName + " " +  customer.LastName;

                return Ok(appointmentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, AppointmentDTO appointmentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if(id <= 0 || appointmentDTO == null)
            {
                return BadRequest();
            }

            try
            {
                var customer = _context.Customer.Find(appointmentDTO.IdCustomer);
                if( customer == null)
                {
                    return BadRequest();
                }

                var appointment = _context.Appointment.Find(id);
                if(appointment == null)
                {
                    return BadRequest();
                }

                appointment.DateAndTime = appointmentDTO.DateAndTime;
                appointment.Customer = customer;

                _context.Appointment.Update(appointment);
                _context.SaveChanges();

                return Ok(appointmentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);
            }
        }


        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            if(id <= 0)
            { return BadRequest(); }

            try
            {
                var appBase = _context.Appointment.Find(id);
                if(appBase == null)
                {
                    return BadRequest();
                }

                _context.Appointment.Remove(appBase);
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
