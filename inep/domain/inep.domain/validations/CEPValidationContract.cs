using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{   
    public class CEPValidationContract : Contract<CEP>
    {
         const string regex_padrao = @"^\d{8}$";
        

        internal CEPValidationContract(CEP cep)
        {
            Requires()
                .Matches(cep.Numero, regex_padrao, "CEP", "Cep inválido");

        }
    }

    
    
}
