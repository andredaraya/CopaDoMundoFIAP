using System;

namespace CopaDoMundo.Web.Servico.DTO
{
    public abstract class EntidadeDTO
    {
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
