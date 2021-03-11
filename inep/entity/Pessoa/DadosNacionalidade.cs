using System;
using System.Collections.Generic;

namespace INEP
{
    public class DadosNacionalidade : DadosInterface
    {
        public long Codigo { get; set; }
        public string Descricao { get; set; }

        public List<object> getDados()
        {
            var lista = new List<object>();

            lista.Add(Add(1, "Brasileira"));
            lista.Add(Add(2, "Brasileira Nascido no Exterior ou Naturalizado"));
            lista.Add(Add(2, "Estrangeira"));


            return lista;
        }

        private object Add(long codigo, string decricao)
        {
            var objeto = new DadosNacionalidade();
            objeto.Codigo = codigo;
            objeto.Descricao = decricao;
            return objeto;

        }
    }
}
