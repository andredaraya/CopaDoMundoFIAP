using System;

namespace CopaDoMundo.Web.Cross.DTO
{
    public interface IEntidadeDTO
    {
        DateTime CriadoEm { get; set; }
        bool Ativo { get; set; }
    }
}
