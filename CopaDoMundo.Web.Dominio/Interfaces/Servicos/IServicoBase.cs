using CopaDoMundo.Web.Cross.DTO;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Dominio.Interfaces.Servicos
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
