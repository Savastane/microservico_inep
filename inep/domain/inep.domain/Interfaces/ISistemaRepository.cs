using inep.domain.documentos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inep.domain.interfaces
{
    public interface ISistemaRepository
    {
        Task<Escola> CriarBanco(string nome);

        Task<Escola> CriarDocumentos(string nome);


    }
}
