using System;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Servico.DTO
{
    public class SelecaoDTO : IEntidadeDTO
    {
        public SelecaoDTO()
        {
            this.Jogadores = new List<JogadorDTO>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public int QuantidadeTitulos { get; set; }
        public virtual IList<JogadorDTO> Jogadores { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
