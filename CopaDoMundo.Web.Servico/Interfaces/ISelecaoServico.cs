using CopaDoMundo.Web.Servico.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface ISelecaoServico : IServicoBase<SelecaoDTO>
    {
        Task<IEnumerable<SelecaoDTO>> BuscarTodosAtivos();
    }
}
