using CopaDoMundo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface ISelecaoServico : IServicoBase<Selecao>
    {
        Task<IEnumerable<Selecao>> BuscarTodosAtivos();
    }
}
