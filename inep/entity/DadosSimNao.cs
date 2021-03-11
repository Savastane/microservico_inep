using System;
using System.Collections.Generic;

namespace INEP
{
    public class DadosSimNao: DadosInterface
    {
        public long Codigo { get; set; }
        public string Descricao { get; set; }

        public List<object> getDados()
        {
            var lista = new List<object>();

            lista.Add(Add(0, "Não"));
            lista.Add(Add(1, "Sim"));
            
            return lista;
        }

        private object Add(long codigo, string decricao)
        {
            var objeto = new DadosSimNao();
            objeto.Codigo = codigo;
            objeto.Descricao = decricao;
            return objeto;

        }
    }
}
