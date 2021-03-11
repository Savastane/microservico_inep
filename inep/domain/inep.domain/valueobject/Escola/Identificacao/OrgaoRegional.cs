using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class OrgaoRegional : Notifiable<Notification>
    {

        
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        
        public OrgaoRegional(string Codigo, string Nome)
        {
            this.Codigo = Codigo;
            AddNotifications(new OrgaoRegionalValidationContract(this));
        }


    }
}


