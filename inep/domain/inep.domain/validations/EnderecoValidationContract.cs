using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class EnderecoValidationContract : Contract<Endereco>
    {
        public EnderecoValidationContract(Endereco endereco)
        {

            var regex_padrao = @"^[ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ªº–., ]*$";
            
            Requires()

                // municipio
                .IsNotNullOrEmpty(endereco.Municipio, "Municipio", "Código Municipio não foi preenchido ")
                .AreEquals(endereco.Municipio.Length, 7, "Municipio", "Código  do Municipio Tamanho máximo do campo é 7 caracteres")

                // distrito
                .IsNotNullOrEmpty(endereco.Distrito, "Distrito", "Código Distrito  não foi preenchido ")
                .AreEquals(endereco.Distrito.Length, 7, "Distrito", "Código Distrito tamanho máximo do campo é 7 caracteres")

                //logradouro
                .IsNotNullOrEmpty(endereco.Logradouro, "Endereco", "Endereço/Logradouro não foir preenchido ")
                .AreEquals((endereco.Logradouro.Length <=100), true, "Endereco", "Tamanho máximo do campo é 100 caracteres")
                .Matches(endereco.Logradouro, regex_padrao, "Endereco", "Permitido apenas endereco cujo o logradouro não tenha acentuacao")
                // numero
                
                .AreEquals((endereco.Numero.Length <= 10), true, "Numero", "Tamanho máximo do campo é 10 caracteres")
                .Matches(endereco.Numero, regex_padrao, "Numero", "Permitido apenas endereco cujo o Numero não tenha acentuacao")

                //Complemento
                
                .AreEquals((endereco.Complemento.Length <= 20), true, "Complemento", "Tamanho máximo do campo é 20 caracteres")                
                .Matches(endereco.Complemento, regex_padrao, "Complemento", "Permitido apenas endereco cujo o Complemento não tenha acentuacao")

                //Bairro                
                .AreEquals((endereco.Bairro.Length <= 50), true, "Bairro", "Tamanho máximo do campo é 50 caracteres")                
                .Matches(endereco.Bairro, regex_padrao, "Bairro", "Permitido apenas descrição que não tenha acentuacao");

            
        }
    }

    
    
}
