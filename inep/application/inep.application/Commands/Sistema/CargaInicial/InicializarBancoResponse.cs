using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Commands

{
    public class InicializarBancoResponse
    {
        public bool  BancoCriado { get;   set; }
        public bool  DocumentosInicializados { get; set; }
        public dynamic Notifications { get; set; }
    }
}
