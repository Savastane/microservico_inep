using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class EmailValidationContract : Contract<Email>
    {
        public EmailValidationContract(Email email)
        {            
            Requires()
                 .IsEmailOrEmpty(email.Endereco, "Email", "Email Inválido ou em branco");             
        }
    }

    
    
}
