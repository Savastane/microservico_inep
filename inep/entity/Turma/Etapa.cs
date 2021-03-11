using System;
using System.Collections.Generic;
using System.Text;

namespace INEP.Turma
{
    public class Etapa : DadosInterface
    {

        public long Codigo { get; set;  }
        public string Descricao { get; set; }


        public List<object> getDados()
        {
            var lista = new List<object>();

            lista.Add(Add(1, "Educação infantil - creche (0 a 3 anos)"));
            lista.Add(Add(2, "Educação infantil - pré-escola (4 e 5 anos)"));
            lista.Add(Add(3, "Educação infantil - unificada (0 a 5 anos)"));
            lista.Add(Add(14, "Ensino fundamental de 9 anos - 1º Ano"));
            lista.Add(Add(15, "Ensino fundamental de 9 anos - 2º Ano"));
            lista.Add(Add(16, "Ensino fundamental de 9 anos - 3º Ano"));
            lista.Add(Add(17, "Ensino fundamental de 9 anos - 4º Ano"));
            lista.Add(Add(18, "Ensino fundamental de 9 anos - 5º Ano"));
            lista.Add(Add(19, "Ensino fundamental de 9 anos - 6º Ano"));
            lista.Add(Add(20, "Ensino fundamental de 9 anos - 7º Ano"));
            lista.Add(Add(21, "Ensino fundamental de 9 anos - 8º Ano"));
            lista.Add(Add(22, "Ensino Fundamental de 9 anos - multi"));
            lista.Add(Add(23, "Ensino Fundamental de 9 anos - correção de fluxo"));
            lista.Add(Add(25, "Ensino médio - 1ª Série"));
            lista.Add(Add(26, "Ensino médio - 2ª Série"));
            lista.Add(Add(27, "Ensino médio - 3ª Série"));
            lista.Add(Add(28, "Ensino médio - 4ª Série"));
            lista.Add(Add(29, "Ensino médio - não seriada"));
            lista.Add(Add(30, "Curso técnico integrado (ensino médio integrado) 1ª Série"));
            lista.Add(Add(31, "Curso técnico integrado (ensino médio integrado) 2ª Série"));
            lista.Add(Add(32, "Curso técnico integrado (ensino médio integrado) 3ª Série"));
            lista.Add(Add(33, "Curso técnico integrado (ensino médio integrado) 4ª Série"));
            lista.Add(Add(34, "Curso técnico integrado (ensino médio integrado) não seriada"));
            lista.Add(Add(35, "Ensino médio - normal/magistério 1ª Série"));
            lista.Add(Add(36, "Ensino médio - normal/magistério 2ª Série"));
            lista.Add(Add(37, "Ensino médio - normal/magistério 3ª Série"));
            lista.Add(Add(38, "Ensino médio - normal/magistério 4ª Série"));
            lista.Add(Add(39, "Curso técnico  - concomitante"));
            lista.Add(Add(40, "Curso técnico  - subsequente"));
            lista.Add(Add(41, "Ensino fundamental de 9 anos - 9º Ano"));
            lista.Add(Add(69, "EJA - ensino fundamental -  anos iniciais"));
            lista.Add(Add(70, "EJA - ensino fundamental -  anos finais"));
            lista.Add(Add(71, "EJA - ensino médio"));
            lista.Add(Add(72, "EJA - ensino fundamental  - anos iniciais e anos finais"));
            lista.Add(Add(56, "Educação infantil e ensino fundamental de 9 anos - multietapa"));
            lista.Add(Add(73, "Curso FIC integrado na modalidade EJA – nível fundamental (EJA integrada à educação profissional de nível fundamental)"));
            lista.Add(Add(74, "Curso técnico integrado na modalidade EJA (EJA integrada à educação profissional de nível médio)"));
            lista.Add(Add(64, "Curso técnico misto"));
            lista.Add(Add(67, "Curso FIC integrado na modalidade EJA  - nível médio"));
            lista.Add(Add(68, "Curso FIC concomitante"));


            return lista;
        }

        private Etapa Add(long codigo , string decricao)
        {
            var etapa = new Etapa();
            etapa.Codigo = codigo;
            etapa.Descricao = decricao.TrimStart().TrimEnd().Trim(); 
            return etapa;

        }


        
    }

}

