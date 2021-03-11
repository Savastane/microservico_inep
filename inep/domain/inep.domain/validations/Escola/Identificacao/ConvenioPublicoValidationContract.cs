using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class ConvenioPublicoValidationContract : Contract<ConvenioPoderPublico>
    {
        public ConvenioPublicoValidationContract(ConvenioPoderPublico convenio)
        {


            if ((convenio.Situacao == "1") && (convenio.DependenciaAdministrativa == "4"))
            {
                long? codigo = Convert.ToInt64(String.IsNullOrEmpty(convenio.Codigo) ? null : Convert.ToInt64(convenio.Codigo));

                Requires()
                    .IsNotNullOrEmpty(convenio.Codigo, "ConvenioPoderPublico", "Quando Situação 1 Categoria é obrigatoria")
                    .IsBetween(codigo ?? 0, 1, 3, "ConvenioPoderPublico", "Somente aceita os seguintes caracteres entre parêntesis: (1 2 3).Legenda: 1 – estadual 2 – municipal 3 – estadual e municipal");

                /*
                 *  
                 
                 * */
            }
            else
            {
                Requires()
                .IsNullOrEmpty(convenio.Codigo, "ConvenioPoderPublico", "Campo não pode ser preenchido");

            }




        }
    }

    
    
}
