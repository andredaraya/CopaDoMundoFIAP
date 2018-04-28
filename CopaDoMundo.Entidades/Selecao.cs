using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDoMundo.Model
{
    public class Selecao : EntidadeBase
    {
        public Selecao()
        {
            this.Jogadores = new List<Jogador>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public int QuantidadeTitulos { get; set; }
        public virtual IList<Jogador> Jogadores { get; set; }
    }
}
