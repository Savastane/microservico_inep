using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class MatenedoraEscolaPrivada : Notifiable<Notification>
    {

        
        public string EmpresaGrupoEmpresarialPessoaFisica { get; private set; }
        public string InstituicaoSemFinsLucrativos { get; private set; }
        public string ONG { get; private set; }
        public string OSCIP { get; private set; }
        public string Sindicato { get; private set; }
        public string SistemaS { get; private set; }


        public MatenedoraEscolaPrivada(string EmpresaGrupoEmpresarialPessoaFisica, string InstituicaoSemFinsLucrativos, 
            string ONG, string OSCIP, string Sindicato, string SistemaS)
        {
            this.EmpresaGrupoEmpresarialPessoaFisica = EmpresaGrupoEmpresarialPessoaFisica;
            this.InstituicaoSemFinsLucrativos = InstituicaoSemFinsLucrativos;
            this.ONG = ONG;
            this.OSCIP = OSCIP;
            this.Sindicato = Sindicato;
            this.SistemaS = SistemaS;
            
        }


    }
}


