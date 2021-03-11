using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace inep.domain
{
    public class PeriodoLetivo : Notifiable<Notification>
    {


        /// <summary>
        /// Sem vínculo com outra instituição Unidade vinculada à escola de educação básica Unidade ofertante de educação superior
        /// </summary>
        /// 
        [NotMapped]
        public String Key{ get; private set; }
        
        [NotMapped]
        public string SituacaoEscola { get; private set; }
        [NotMapped]
        public DateTime DataReferenciaCenso { get; private set; }

        public DateTime? InicioAnoLetivo { get; private set; }
        public DateTime? FinalAnoLetivo { get; private set; }


        public PeriodoLetivo( string Key, DateTime? InicioAnoLetivo, DateTime? FinalAnoLetivo, string SituacaoEscola, DateTime DataReferenciaCenso)
        {
            this.Key = Key;
            this.SituacaoEscola = SituacaoEscola;
            this.InicioAnoLetivo = InicioAnoLetivo;
            this.FinalAnoLetivo = FinalAnoLetivo;
            this.DataReferenciaCenso = DataReferenciaCenso;

            AddNotifications(new PeriodoLetivoEscolaValidationContract(this));

        }


    }
}


