using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class DependenciaAdministrativa : Notifiable<Notification>
    {


        /// <summary>
        /// Sem vínculo com outra instituição Unidade vinculada à escola de educação básica Unidade ofertante de educação superior
        /// </summary>
        public string Codigo { get; private set; }
        public string CodigoMunicipio { get; private set; }



        public DependenciaAdministrativa(string Codigo , string CodigoMunicipio)
        {
            this.Codigo = Codigo;
            this.CodigoMunicipio = CodigoMunicipio;

            AddNotifications(new DependenciaAdministrativaValidationContract(this));
        
        }


    }
}


