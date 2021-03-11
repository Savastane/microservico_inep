using Flunt.Notifications;
using System;
using System.Collections.Generic;


namespace inep.domain.documentos
{
    
    // comportamentos
    //validacoes
    public class Escola :  Notifiable<Notification>
    {

        public Escola(string KEY, string NomeFantasia)
        {
            this.KEY = KEY;
            this.NomeFantasia = NomeFantasia;

            
        }

        public void SetIdentificacao(string Id, Identificacao Identificacao)
        {
            
            this.Identificacao = Identificacao;
            AddNotifications(Identificacao.Notifications);
        }

        //public void SetId(string Id)
        //{
        //    if (!(String.IsNullOrEmpty(Id)))
        //    {
        //        this.Id = "escolas/" + Id;
        //    }

        //}

        public string Id { get; private set; }
        public string KEY { get; private set; }
        public string NomeFantasia { get; private set; }

        public Identificacao Identificacao { get; private set; }
        public InfraEstrutura InfraEstrutura { get; private set; }
        public Equipamentos Equipamentos { get; private set; }
        public RecursosHumanos RecursosHumanos { get; private set; }
        public Alimentacao Alimentacao { get; private set; }
        public Organizacao Organizacao { get; private set; }










    }
}
