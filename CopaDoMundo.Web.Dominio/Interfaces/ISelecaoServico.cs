using CopaDoMundo.Web.Servico.DTO;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface ISelecaoServico : IServicoBase<SelecaoDTO>
    {
        IEnumerable<SelecaoDTO> BuscarTodosAtivos();
    }
}
