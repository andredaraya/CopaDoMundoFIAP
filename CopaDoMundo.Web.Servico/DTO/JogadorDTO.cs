using System;

namespace CopaDoMundo.Web.Servico.DTO
{
    public class JogadorDTO : EntidadeDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public SelecaoDTO Selecao { get; set; }
    }
}
