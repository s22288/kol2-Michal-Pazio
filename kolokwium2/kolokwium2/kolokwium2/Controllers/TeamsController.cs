using fighterFighters.Service;
using kolokwium2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public TeamsController(IDbService dbService)
        {
            _dbService = dbService;
        }

      
        [HttpGet("{id}")]
        public async Task<IActionResult> AddUser(Member user,Team team)
        {

            var actionInfo = await _dbService.GetInfoAboutAction(id);
            if (!actionInfo.Any())
            {
                return BadRequest(" 404 Nie ma żadnych akcji o tym id");
            }

            return Ok(actionInfo);
        }
      
    }
}
