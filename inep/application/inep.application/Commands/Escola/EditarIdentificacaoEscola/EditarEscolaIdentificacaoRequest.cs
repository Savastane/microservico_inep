using inep.domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Commands
{
    public class EditarEscolaIdentificacaoRequest : IRequest<EditarEscolaIdentificacaoResponse>
    {
                      
        public string Id { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Situacao { get; set; }

        public DateTime InicioAnoLetivo { get; set; }

        public DateTime FinalAnoLetivo { get; set; }

        public string CEP { get; set; }

        public string UF { get;  set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

        public string Distrito { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; private set; }

        public string LocalizacaoGeografica { get; private set; }

        public string Bairro { get; private set; }


    }
}
