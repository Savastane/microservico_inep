using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class Email: Notifiable<Notification>
    {
        public string  Endereco { get; private set; }

        public  Email(string endereco)
        {
            this.Endereco = endereco;
            AddNotifications(new EmailValidationContract(this));
        }


    }
}
