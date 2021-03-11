using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class VinculoOrgaoPublico : Notifiable<Notification>
    {

        
        public string SecretariaEducacao { get; private set; }
        public string SecretariaSeguranca { get; private set; }
        public string SecretariaSaude { get; private set; }
        public string OutroOrgaoAdministracaoPublica { get; private set; }
        public string DependenciaAdministrativa { get; private set; }

        public VinculoOrgaoPublico(string SecretariaEducacao, string SecretariaSeguranca, string SecretariaSaude, string OutroOrgaoAdministracaoPublica, string DependenciaAdministrativa )
        {
            this.SecretariaEducacao = SecretariaEducacao;
            this.SecretariaSeguranca = SecretariaSeguranca;
            this.SecretariaSaude = SecretariaSaude;
            this.OutroOrgaoAdministracaoPublica = OutroOrgaoAdministracaoPublica;
            this.DependenciaAdministrativa = DependenciaAdministrativa;

            AddNotifications(new VinculoOrgaoPublicoValidationContract(this));
        }


    }
}


