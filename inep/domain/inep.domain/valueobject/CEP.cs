using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class CEP : Notifiable<Notification>
    {

        public const int MaxLenght = 8;

        public string Numero { get; private set; }


        public CEP(string numero)
        {
            this.Numero = numero;
            AddNotifications(new CEPValidationContract(this));
        }


    }
}
