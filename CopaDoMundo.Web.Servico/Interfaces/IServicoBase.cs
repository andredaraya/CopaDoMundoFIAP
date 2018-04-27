using CopaDoMundo.Web.Servico.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface IServicoBase<TEntidadeDTO> where TEntidadeDTO : EntidadeDTO
    {
        Task Add(TEntidadeDTO entity);
        Task<TEntidadeDTO> BuscarPorId(int id);
        Task<IEnumerable<TEntidadeDTO>> BuscarTodos();
        Task Atualizar(TEntidadeDTO entidade);
        Task Remover(int id);
    }
}
