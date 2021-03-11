using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class TelefoneValidationContract : Contract<Telefone>
    {
        public TelefoneValidationContract(Telefone telefone, bool obrigatorio = false)
        {
            const string regex_ddd = @"^\d{3}$";
            const string regex_telefone = @"^[0-9]{4,5}-?[0-9]{4}$";

            var requerido = Requires();

            if (obrigatorio)
            {


                requerido.IsNotNullOrEmpty(telefone.DDD, telefone.KEY, "Campo requerido");
                requerido.IsNotNullOrEmpty(telefone.Numero, telefone.KEY, "Campo requerido");

            }

            requerido                
                .Matches(telefone.DDD, regex_ddd, telefone.KEY, "DDD invalido")
                .Matches(telefone.Numero, regex_telefone, telefone.KEY, "DDD invalido");


        }
    }

    
    
}
