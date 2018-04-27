using System;

namespace CopaDoMundo.Web.Servico.DTO
{
    public interface IEntidadeDTO
    {
        DateTime CriadoEm { get; set; }
        bool Ativo { get; set; }
    }
}
