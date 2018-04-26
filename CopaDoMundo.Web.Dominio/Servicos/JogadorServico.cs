using CopaDoMundo.Web.Cross.DTO;
using CopaDoMundo.Web.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Dominio.Servicos
{
    public class JogadorServico : IJogadorServico
    {
        public JogadorServico()
        {

        }

        public void Add(JogadorDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(JogadorDTO entidade)
        {
            throw new NotImplementedException();
        }

        public JogadorDTO BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JogadorDTO> BuscarPorSelecao(int selecaoId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JogadorDTO> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JogadorDTO> BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
