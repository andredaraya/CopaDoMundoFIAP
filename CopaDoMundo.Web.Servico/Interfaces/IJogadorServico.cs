using CopaDoMundo.Web.Servico.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface IJogadorServico : IServicoBase<JogadorDTO>
    {
        Task<IEnumerable<JogadorDTO>> BuscarTodosAtivos();
        Task<IEnumerable<JogadorDTO>> BuscarPorSelecao(int selecaoId);
    }
}
