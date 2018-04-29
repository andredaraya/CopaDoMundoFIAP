using CopaDoMundo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.WebApi.Dados.Interface
{
    public interface ISelecaoRepositorio
    {
        void CadastrarSelecao(Selecao model);

        void AtualizarSelecao(Selecao model);

        void DeletarSelecao(int id);

        Selecao BuscaSelecaoPorId(int id);

        IList<Selecao> ListaSelecoes();
    }
}
