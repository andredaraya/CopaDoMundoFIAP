using System;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Cross.DTO
{
    public class SelecaoDTO : IEntidadeDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int QuantidadeTitulos { get; set; }
        public virtual IEnumerable<JogadorDTO> Jogadores { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
