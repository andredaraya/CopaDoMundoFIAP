using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDoMundo.Model
{
    public class Jogador : EntidadeBase
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public int Selecao { get; set; }
    }
}
