using System;

namespace CopaDoMundo.Web.Cross.DTO
{
    public class JogadorDTO : IEntidadeDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public SelecaoDTO Selecao { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
