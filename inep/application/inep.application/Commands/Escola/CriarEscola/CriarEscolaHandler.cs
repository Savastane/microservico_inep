using Flunt.Notifications;
using inep.domain.interfaces;
using inep.domain.entities;
using inep.domain.documentos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inep.application.Commands
{
    
    public class CriarEscolaHandler :  IRequestHandler<CriarEscolaRequest, CriarEscolaResponse>
    {
        private readonly IEscolaRepository _escolaRepository;
        public CriarEscolaHandler(IEscolaRepository repository)
        {
            _escolaRepository = repository;
        }

        public Task<CriarEscolaResponse> Handle(CriarEscolaRequest request, CancellationToken cancellationToken)
        {

            Escola escola = new Escola(request.KEY, request.NomeFantasia);
                        

            var resultado = new CriarEscolaResponse
            {
                Notifications = escola.Notifications
            }; 

            if (escola.IsValid)
            {
                var escolaresponse = _escolaRepository.Update(escola).Result;                                
                resultado.KEY = escolaresponse.KEY;
                resultado.NomeFantasia = escolaresponse.NomeFantasia;
            }
            
            

            return Task.FromResult(resultado);


        }


    }
}
