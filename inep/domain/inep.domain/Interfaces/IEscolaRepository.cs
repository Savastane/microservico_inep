using inep.domain.documentos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inep.domain.interfaces
{
    public interface IEscolaRepository
    {
        Task<List<Escola>> GetEscolas();
        Task<Escola> GetById(string Id);

        Task<Escola> Add(Escola escola);
        Task<Escola> Update(Escola escola);

        void UpdateIdentificacao(string id, Identificacao identificacao);

        void Remove(Escola escola);

        

    }
}
