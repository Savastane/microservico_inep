using Flunt.Notifications;
using System;
using System.Collections.Generic;


namespace inep.domain.entities
{
    
    // comportamentos
    //validacoes
    public class Aluno :  Notifiable<Notification>
    {

        
        public Aluno(string codigo, string nome, string email)
        {

            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = new Email(email);
                     
            AddNotifications(this.Email.Notifications);
        }

        public void SetId(string Id)
        {
            if (!(String.IsNullOrEmpty(Id)))
            {
                this.Id = "escolas/" + Id;
            }
                
            
        }
        
        public string Id { get;  set; }

        public string Codigo { get; private set; }
        
        public string Nome { get; private set; }

        public Email Email { get; private set; }


        

    }
}
