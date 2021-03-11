using inep.domain.interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inep.application.Queries
{
    public class ObterEscolasQueryHandler : IRequestHandler<ObterEscolasQuery, List<ObterEscolasQuery>>
    {
        private readonly IEscolaRepository _escolaRepository;

        public ObterEscolasQueryHandler(IEscolaRepository repository)
        {
            _escolaRepository = repository;
        }

    


        public Task<List<ObterEscolasQuery>> Handle(ObterEscolasQuery request, CancellationToken cancellationToken)
        {
                        
            var escolas = _escolaRepository.GetEscolas();

            var result = escolas.Result.Select(s => new ObterEscolasQuery(null) { Nome= s.NomeFantasia }).ToList();

            return Task.FromResult(result);

        }
    }
}
