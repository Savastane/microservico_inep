using inep.application;
using inep.application.Commands;
using inep.application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inep.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SistemaController : ControllerBase
    {

        


        [HttpGet]
        [Route("Importar")]
        public async Task<IActionResult> Importar([FromServices] IMediator mediator, [FromBody] InicializarBancoRequest command)
        {


            var result = await mediator.Send(command);

            if (result.Notifications.Count > 0)
            {
                return BadRequest(result.Notifications);
            }
            return Ok(result);
        }


      
        

        [HttpGet]
        [Route("OK")]
        public async Task<IActionResult> Ok()
        {

            return Ok("OK");

        }
    }
}
