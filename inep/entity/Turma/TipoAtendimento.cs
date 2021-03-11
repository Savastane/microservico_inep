using System;
using System.Collections.Generic;
using System.Text;

namespace INEP.Turma
{
    /// <summary>
    /// TIPO DE MEDIAÇÃO DIDÁTICO-PEDAGÓGICA 
    /// Compreende os tipos de relações e interações realizadas no processo de ensino-aprendizagem,
    /// estimuladas ou não pelo professor.
    /// Subdivide-se em três categorias:
    /// </summary>
    /// 
    public class TipoAtendimento : DadosInterface
    {

        public long Codigo { get; set;  }
        public string Descricao { get; set; }


        public List<object> getDados()
        {
            var lista = new List<object>();

            lista.Add(Add(1, "Presencial"));
            lista.Add(Add(2, "Semipresencial"));
            lista.Add(Add(3, "A distância (EAD)"));
            

            return lista;
        }

        private object Add(long codigo , string decricao)
        {
            var objeto = new TipoAtendimento();
            objeto.Codigo = codigo;
            objeto.Descricao = decricao;
            return objeto;

        }


        
    }

}

