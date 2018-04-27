using CopaDoMundo.Web.Servico.DTO;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Servico.Interfaces
{
    public interface IServicoBase<TEntidadeDTO> where TEntidadeDTO : IEntidadeDTO
    {
        void Add(TEntidadeDTO entity);
        TEntidadeDTO BuscarPorId(int id);
        IEnumerable<TEntidadeDTO> BuscarTodos();
        void Atualizar(TEntidadeDTO entidade);
        void Remover(int id);
        void Dispose();
    }
}
