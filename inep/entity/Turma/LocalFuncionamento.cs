using System;
using System.Collections.Generic;
using System.Text;

namespace INEP.Turma
{

    //LOCAL DE FUNCIONAMENTO DIFERENCIADO DA TURMA
    //Local onde as atividades da turma são realizadas.    As categorias disponíveis são:

    public class LocalFuncionamento : DadosInterface
    {

        public long Codigo { get; set;  }
        public string Descricao { get; set; }


        public List<object> getDados()
        {

            var lista = new List<object>();
            lista.Add(Add(0, "A turma não está em local de funcionamento diferenciado"));
            lista.Add(Add(1, "Sala anexa"));
            lista.Add(Add(2, "Unidade de atendimento socioeducativo"));
            lista.Add(Add(3, "Unidade prisional"));
            

            return lista;
        }

        private object Add(long codigo , string decricao)
        {
            var objeto = new LocalFuncionamento();
            objeto.Codigo = codigo;
            objeto.Descricao = decricao;
            return objeto;

        }


        
    }

}

