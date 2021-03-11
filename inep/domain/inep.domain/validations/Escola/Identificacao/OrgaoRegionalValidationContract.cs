using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class OrgaoRegionalValidationContract : Contract<OrgaoRegional>
    {
        public OrgaoRegionalValidationContract(OrgaoRegional OrgaoRegional)
        {

            Requires()
                .IsNotNullOrEmpty(OrgaoRegional.Codigo, "OrgaoRegional", "Campo Requerido")
                .AreEquals((OrgaoRegional.Codigo.Length <= 5), true, "OrgaoRegional", "Tamanho máximo do campo é 5 caracteres");
                
                
            
        }
    }

    
    
}
