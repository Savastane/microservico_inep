using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Commands

{
    public class EditarEscolaIdentificacaoResponse
    {

        
        public string Codigo { get;  set; }

        public string NomeFantasia { get; set; }

        public string Nome { get; set; }

        public string Situacao { get;  set; }

        public DateTime InicioAnoLetivo { get; set; }

        public DateTime FinalAnoLetivo { get;  set; }



        public dynamic Notifications { get; set; }
    }
}
