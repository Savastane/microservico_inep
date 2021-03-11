using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class ConvenioPoderPublico : Notifiable<Notification>
    {


        /// <summary>
        /// Sem vínculo com outra instituição Unidade vinculada à escola de educação básica Unidade ofertante de educação superior
        /// </summary>
        public string Codigo { get; private set; }
        public string Situacao { get; private set; }
        public string DependenciaAdministrativa { get; private set; }



        public ConvenioPoderPublico(string Codigo , string Situacao, string DependenciaAdministrativa)
        {
            this.Codigo = Codigo;
            this.Situacao = Situacao;
            this.DependenciaAdministrativa = DependenciaAdministrativa;

            AddNotifications(new ConvenioPublicoValidationContract(this));
        
        }


    }
}


