using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Queries
{
    public class ObterEscolasQuery : IRequest<List<ObterEscolasQuery>>
    {


        private ObterEscolasInputModel inputmodel;


        public ObterEscolasQuery(ObterEscolasInputModel inputmodel)
        {
            this.inputmodel = inputmodel;

        }

        public string Codigo { get; set; }

        public string Nome { get; set; }

    }
}
