using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class LocalizacaoValidationContract : Contract<Localizacao>
    {
        public LocalizacaoValidationContract(Localizacao loalizacao)
        {


            decimal permitidos = Convert.ToDecimal(String.IsNullOrEmpty(loalizacao.Codigo) ? 0 : Convert.ToDecimal(loalizacao.Codigo));

            Requires()
                .IsNotNullOrEmpty(loalizacao.Codigo, "Localizacao", "Localização pode ser vazio nem nulo")
                .IsBetween(permitidos, 1, 3, "Localizacao", "os valores permitidos são [1] Urbano, [2]  Rural");



        }
    }

    
    
}
