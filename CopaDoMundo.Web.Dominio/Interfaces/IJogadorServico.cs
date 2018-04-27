using CopaDoMundo.Web.Servico.DTO;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface IJogadorServico : IServicoBase<JogadorDTO>
    {
        IEnumerable<JogadorDTO> BuscarTodosAtivos();
        IEnumerable<JogadorDTO> BuscarPorSelecao(int selecaoId);
    }
}
