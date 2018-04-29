using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDoMundo.Model
{
    public abstract class EntidadeBase
    {
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
