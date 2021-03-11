using System;
using System.Collections.Generic;
using System.Text;

namespace INEP.Turma
{


    
    public class Modalidade : DadosInterface
    {



        public long Codigo { get; set;  }
        public string Descricao { get; set; }


        public List<object> getDados()
        {
            var lista = new List<object>();

            lista.Add(Add(1, "Ensino regular"));
            lista.Add(Add(2, "Educação especial – Modalidade substitutiva"));
            lista.Add(Add(3, "Educação de jovens e adultos (EJA)"));
            lista.Add(Add(4, "Educação profissional"));

            return lista;
        }

        private object Add(long codigo , string decricao)
        {
            var objeto = new Modalidade();
            objeto.Codigo = codigo;
            objeto.Descricao = decricao;
            return objeto;

        }


        
    }

}

