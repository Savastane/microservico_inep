using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class VinculoOrgaoPublicoValidationContract : Contract<VinculoOrgaoPublico>
    {
        public VinculoOrgaoPublicoValidationContract(VinculoOrgaoPublico vinculo)
        {
            /* verificar direito 
            var requerido = Requires()
                    
                    .Contains(vinculo, new long[] { 1, 2, 3, 7 }, "VinculoOrgaoPublico", "os valores permitidos são  1 – Área de assentamento 2 – Terra indígena 3 – Área onde se localiza comunidade remanescente de quilombos  7 – Não está em área de localização diferenciada");


            if ("123".Contains(vinculo.DependenciaAdministrativa))
            {
                requerido
                    .IsNotNullOrEmpty(vinculo.SecretariaEducacao, "VinculoOrgaoPublico", "Vinculo Secretaria Educação não pode ser vazio nem nulo")
                    .IsNotNullOrEmpty(vinculo.SecretariaSeguranca, "VinculoOrgaoPublico", "Vinculo Secretaria Educação não pode ser vazio nem nulo")
                    .IsNotNullOrEmpty(vinculo.SecretariaSaude, "VinculoOrgaoPublico", "Vinculo Secretaria Educação não pode ser vazio nem nulo")
                    .IsNotNullOrEmpty(vinculo.SecretariaSaude, "VinculoOrgaoPublico", "Vinculo Secretaria Educação não pode ser vazio nem nulo")


                    .AreEquals(vinculo.SecretariaEducacao.Length, 5, "OrgaoRegional", "Código Distrito tamanho máximo do campo é 5 caracteres");
            }
            */
        }
    }

    
    
}
