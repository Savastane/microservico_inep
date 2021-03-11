using Flunt.Notifications;
using inep.domain.valueobject.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain
{
    public class UnidadeVincula : Notifiable<Notification>
    {


        /// <summary>
        /// Sem vínculo com outra instituição Unidade vinculada à escola de educação básica Unidade ofertante de educação superior
        /// </summary>
        public string TipoUnidadeVinculada { get; private set; }
        public string CodigoEscolaSede { get; private set; }
        public string CodigoIES { get; private set; }


        public UnidadeVincula(string TipoUnidadeVinculada, string CodigoEscolaSede, string CodigoIES)
        {
            this.TipoUnidadeVinculada = TipoUnidadeVinculada;
            this.CodigoEscolaSede = CodigoEscolaSede;
            this.CodigoIES = CodigoIES;
        }


    }
}


