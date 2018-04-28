using CopaDoMundo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.WebApi.Dados.Interface
{
    interface IJogadorRepositorio
    {
        IList<Jogador> BuscaJogadoresPorSelecao(int idSelecao);

        void DeletaJogadoresPorSelecao(int idSelecao);
    }
}
