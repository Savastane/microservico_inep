using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Commands
{
    public class CriarEscolaRequest : IRequest<CriarEscolaResponse>
    {

        

        public string KEY { get; set; }

        public string NomeFantasia { get; set; }

    }
}
