using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inep.application.Commands.Sistema.CargaInicial
{
    public class InicializarBancoHandler : IRequestHandler<InicializarBancoRequest, InicializarBancoResponse>
    {
        public Task<InicializarBancoResponse> Handle(InicializarBancoRequest request, CancellationToken cancellationToken)
        {

            // criar banco de dados

            // importar dados basico 

            var resultado = new InicializarBancoResponse
            {
                BancoCriado = true,
                DocumentosInicializados = true,
                Notifications = null
            };


            return Task.FromResult(resultado);
        }
    }
}

