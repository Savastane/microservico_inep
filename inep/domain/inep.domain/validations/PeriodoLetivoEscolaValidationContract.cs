using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class PeriodoLetivoEscolaValidationContract : Contract<PeriodoLetivo>
    {
        public PeriodoLetivoEscolaValidationContract(PeriodoLetivo periodo)
        {

            if (periodo.SituacaoEscola == "1")
            {

                Requires()
                .IsNotNull(periodo.InicioAnoLetivo, periodo.Key, "Data Inicial Obrigatória")
                .IsNotNull(periodo.FinalAnoLetivo, periodo.Key, "Data Inicial Obrigatória");


            }
            else
            {
                Requires()
               .IsNull(periodo.InicioAnoLetivo, periodo.Key, "Data Inicial não pode ser preenchida")
               .IsNull(periodo.FinalAnoLetivo, periodo.Key, "Data Final não pode ser preenchida");

            }
            
        }
    }

    
    
}
