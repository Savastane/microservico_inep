using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class CNPJ : Notifiable<Notification>
    {

        

        public string Numero { get; private set; }


        public CNPJ(string numero)
        {
            this.Numero = numero;
          
        }


    }
}
