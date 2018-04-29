using CopaDoMundo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Interfaces
{

    public interface IServicoBase<TEntidade> where TEntidade : EntidadeBase

    {
        Task Add(TEntidade entity);
        Task<TEntidade> BuscarPorId(int id);
        Task<IEnumerable<TEntidade>> BuscarTodos();
        Task Atualizar(TEntidade entidade);
        Task Remover(int id);
    }
}
