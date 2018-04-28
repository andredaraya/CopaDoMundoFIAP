using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.WebApi.Servico
{
    public class SelecaoServico
    {
        public void CadastrarSelecao(Selecao model)
        {
            var repo = new SelecaoRepositorio();
            repo.CadastrarSelecao(model);
        }

        public void AtualizarSelecao(Selecao model)
        {
            var repo = new SelecaoRepositorio();
            repo.AtualizarSelecao(model);
        }

        internal void DeletarSelecao(int id)
        {
            var jogadorRepositorio = new JogadorRepositorio();
            var selecaoRepositorio = new SelecaoRepositorio();

            jogadorRepositorio.DeletaJogadoresPorSelecao(id);
            selecaoRepositorio.DeletarSelecao(id);
        }

        internal IList<Selecao> ListarSelecoes()
        {
            var selecaoRepositorio = new SelecaoRepositorio();
            return selecaoRepositorio.ListaSelecoes();
        }

        internal Selecao BuscaSelecaoPorId(int id)
        {
            var selecaoRepositorio = new SelecaoRepositorio();
            return selecaoRepositorio.BuscaSelecaoPorId(id);
        }
    }
}
