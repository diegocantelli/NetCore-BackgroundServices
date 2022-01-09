using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiBackgroundService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"{ DateTime.UtcNow:o}");
        }
    }
}
