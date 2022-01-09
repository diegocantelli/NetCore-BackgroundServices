using ApiBackgroundService.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBackgroundService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommandRepository _commandRepository;

        public CommandController(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }
        [HttpPost]
        public IActionResult SetMessage(string message)
        {
            _commandRepository.SetMessage(message);
            return Ok(_commandRepository.GetMessage());
        }
    }
}
