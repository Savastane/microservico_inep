using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class EsferaAdministrativa : Notifiable<Notification>
    {

        
        public string Federal { get; private set; }
        public string Estadual { get; private set; }
        public string Municipal { get; private set; }

        public EsferaAdministrativa(string Federal, string Estadual, string Municipal)
        {
            this.Federal = Federal;
            this.Estadual = Estadual;
            this.Municipal = Municipal;
        }


    }
}


