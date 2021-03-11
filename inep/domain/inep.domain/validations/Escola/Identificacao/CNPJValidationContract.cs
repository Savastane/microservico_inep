using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class CNPJValidationContract : Contract<string>
    {
        public CNPJValidationContract(string loalizacao)
        {

            Requires()
                .AreEquals(loalizacao.Length, 5, "OrgaoRegional", "Código Distrito tamanho máximo do campo é 5 caracteres");
                
                
            
        }
    }

    
    
}
