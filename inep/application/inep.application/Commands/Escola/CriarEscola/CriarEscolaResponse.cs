﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.application.Commands

{
    public class CriarEscolaResponse
    {
        public string Id { get; set; }
        public string KEY { get; set; }
        public string NomeFantasia { get; set; }        
        public dynamic Notifications { get; set; }
    }
}
