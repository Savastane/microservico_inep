using System;
using System.Collections.Generic;

namespace INEP
{
    public class DadosGenerio : DadosInterface
    {
        public long Codigo { get; set; }
        public string Descricao { get; set; }

        public List<object> getDados()
        {
            var lista = new List<object>();

            lista.Add(Add(1, "Masculino"));
            lista.Add(Add(2, "Feminino"));
            

            return lista;
        }

        private object Add(long codigo, string decricao)
        {
            var objeto = new DadosGenerio();
            objeto.Codigo = codigo;
            objeto.Descricao = decricao;
            return objeto;

        }
    }
}
