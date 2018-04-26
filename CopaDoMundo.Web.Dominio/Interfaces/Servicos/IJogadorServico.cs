using CopaDoMundo.Web.Cross.DTO;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Dominio.Interfaces.Servicos
{
    public interface IJogadorServico : IServicoBase<JogadorDTO>
    {
        IEnumerable<JogadorDTO> BuscarTodosAtivos();
        IEnumerable<JogadorDTO> BuscarPorSelecao(int selecaoId);
    }
}
