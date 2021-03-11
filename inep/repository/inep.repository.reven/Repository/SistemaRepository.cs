using inep.domain.documentos;
using inep.domain.interfaces;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Documents;

namespace inep.repository.raven
{
    public class SistemaRepository : ISistemaRepository
    {
        private readonly IAsyncDocumentSession session;

        public SistemaRepository()
        {
            
        }

        public SistemaRepository(IAsyncDocumentSession dbSession)
        {
            this.session = dbSession;
        }

        public Task<Escola> CriarBanco(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<Escola> CriarDocumentos(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
