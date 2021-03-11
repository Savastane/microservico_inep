using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class SituacaoEscola : Notifiable<Notification>
    {


        /// <summary>
        /// Sem vínculo com outra instituição Unidade vinculada à escola de educação básica Unidade ofertante de educação superior
        /// </summary>
        public string Codigo { get; private set; }
        


        public SituacaoEscola(string Codigo)
        {
            this.Codigo = Codigo;

            AddNotifications(new SituacaoEscolaValidationContract(this));
        
        }


    }
}


