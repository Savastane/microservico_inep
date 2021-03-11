using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class Telefone : Notifiable<Notification>
    {

        public string KEY { get; private set; }

        public string DDD { get; private set; }
        public string Numero { get; private set; }
        
        public Telefone(string DDD, string numero, string KEY)
        {
            this.KEY = KEY;
            this.DDD = DDD;
            this.Numero = numero;

            AddNotifications(new TelefoneValidationContract(this));

            

        }


    }
}


