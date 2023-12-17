using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersionedAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersionNeutral]
    public class HealthController : ControllerBase
    {

        [HttpGet]
        [Route("ping")]

        public IActionResult Ping()
        {
            return Ok( "Everything seems great");
        }
    }
}
