using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SecretsManager.API.Configurations;

namespace SecretsManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretsController(IOptions<DatabaseSettings> databaseSettings) : ControllerBase
    {
        [HttpGet("settings")]
        public IActionResult GetSettings()
        {
            var settings = databaseSettings.Value;
            return Ok(settings);
        }
    }
}
