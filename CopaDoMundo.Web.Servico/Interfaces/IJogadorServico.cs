using CopaDoMundo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface IJogadorServico : IServicoBase<Jogador>
    {
        
        Task<IEnumerable<Jogador>> BuscarTodosAtivos();
        Task<IEnumerable<Jogador>> BuscarPorSelecao(int selecaoId);
    }
}
