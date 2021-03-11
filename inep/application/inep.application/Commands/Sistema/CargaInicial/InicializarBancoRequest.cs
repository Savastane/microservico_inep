using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Commands
{
    public class InicializarBancoRequest : IRequest<InicializarBancoResponse>
    {



        public string Sistema { get; set; }

        
    }
}
