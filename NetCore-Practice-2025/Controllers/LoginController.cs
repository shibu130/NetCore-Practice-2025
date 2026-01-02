using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Practice_2025.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // contructor
        public LoginController() { 
        
        
        }


        [HttpGet("login")]
        public ActionResult ReturnUsername() {


            return Ok(new
            {
                success = true,
                message = "Fetched successfully",
                data = new { id = 1, name = "Shibu" },
                timestamp = DateTime.UtcNow
            });

        }
    }
}
