using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class Endereco: Notifiable<Notification>
    {

        public Endereco(string cep, 
                        string UF,
                        string Estado,
                        string Municipio,
                        string Distrito,
                        string Logradouro,
                        string Numero,
                        string Complemento,
                        string LocalizacaoGeografica,
                        string Bairro)
        {
            this.CEP = new CEP(cep ?? "");
            this.UF = UF ?? "";
            this.Estado = Estado ?? "";
            this.Municipio = Municipio ?? "";
            this.Distrito = Distrito ?? "";
            this.Logradouro = Logradouro ?? "";
            this.Numero = Numero ?? "";
            this.Complemento = Complemento ?? "";
            this.LocalizacaoGeografica = LocalizacaoGeografica ?? "";
            this.Bairro = Bairro ?? "";

            AddNotifications(new CEPValidationContract(this.CEP));
            AddNotifications(new EnderecoValidationContract(this));
                        


        }
        public CEP  CEP { get; private set; }

        public string UF { get; private set; }
        public string Estado { get; private set; }
        public string Municipio{ get; private set; }

        public string Distrito { get; private set; }

        public string Logradouro { get; private set; }

        public string Numero { get; private set; }

        public string Complemento { get; private set; }

        public string LocalizacaoGeografica { get; private set; }

        public string Bairro { get; private set; }

        public Endereco(string endereco)
        {
            this.Logradouro = endereco;         
        }


    }
}


