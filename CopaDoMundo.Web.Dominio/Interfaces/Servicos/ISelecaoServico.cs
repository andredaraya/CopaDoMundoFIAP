using CopaDoMundo.Web.Cross.DTO;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Dominio.Interfaces.Servicos
{
    public interface ISelecaoServico : IServicoBase<SelecaoDTO>
    {
        IEnumerable<SelecaoDTO> BuscarTodosAtivos();
    }
}
