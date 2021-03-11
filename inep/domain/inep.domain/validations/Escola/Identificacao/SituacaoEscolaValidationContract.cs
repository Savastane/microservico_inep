using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class SituacaoEscolaValidationContract : Contract<SituacaoEscola>
    {
        public SituacaoEscolaValidationContract(SituacaoEscola situacao)
        {
            
            decimal situacaoescola = Convert.ToDecimal(String.IsNullOrEmpty(situacao.Codigo) ? 0 : Convert.ToDecimal(situacao.Codigo));

            Requires()
                .IsNotNullOrEmpty(situacao.Codigo, "Situacao", "Situacao da escola não pode ser vazio nem nulo")
                .IsBetween(situacaoescola, 1, 3, "Situacao", "os valores permitidos são [1], [2] ou [3]");
                
        }
    }

    
    
}
