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
    public class EscolaController : ControllerBase
    {



        [HttpPost]
        [Route("criar")]
        public async Task<IActionResult> Criar([FromServices] IMediator mediator, [FromBody] CriarEscolaRequest command)
        {

            var result = await mediator.Send(command);

            if (result.Notifications.Count > 0)
            {
                return BadRequest(result.Notifications);
            }
            return Ok(result);
        }


        [HttpPatch]
        [Route("identificacao/editar")]
        public async Task<IActionResult> Editar([FromServices] IMediator mediator, [FromBody] EditarEscolaIdentificacaoRequest command)
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
