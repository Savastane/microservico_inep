using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class DependenciaAdministrativaValidationContract : Contract<DependenciaAdministrativa>
    {
        public DependenciaAdministrativaValidationContract(DependenciaAdministrativa dependencia)
        {

            long permitidos = Convert.ToInt64(String.IsNullOrEmpty(dependencia.Codigo) ? 0 : Convert.ToInt64(dependencia.Codigo));



            var requerido = Requires()
                .IsNotNullOrEmpty(dependencia.Codigo, "DependenciaAdministrativa", "Dependencia Administrativa  não pode ser vazio nem nulo")
                .Contains(permitidos, new long[] { 1, 2, 3, 4 }, "DependenciaAdministrativa", "Somente aceita os seguintes caracteres entre parêntesis: (1 2 3 4). Legenda: 1 – federal 2 – estadual 3 – municipal 4 – privada");


            if (dependencia.CodigoMunicipio == "5300108")
            {
                requerido.AreNotEquals(dependencia.Codigo, "3", "DependenciaAdministrativa", "Não pode ser preenchido com 3 (municipal) quando o campo 8 (Município) for preenchido com 5300108 (Brasília).");
            }



        }
    }

    
    
}
