using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PolaznikController : ControllerBase
    {
        private readonly EdunovaContext _context;

        public PolaznikController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_context.Polaznik.ToList());
        }


    }
}
