﻿using CopaDoMundo.Model;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.Servico.Options;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Web.Servico.Servicos
{
    public class SelecaoServico : ISelecaoServico
    {
        private readonly SelecaoOptions _options;

        public SelecaoServico(SelecaoOptions options)
        {
            this._options = options;
        }

        public async Task Add(Selecao entidade)
        {
            await this._options.Adicionar
                                .WithHeader("Cache-Control", "no-cache")
                                .PostJsonAsync(entidade);
        }

        public async Task Atualizar(Selecao entidade)
        {
            await this._options.Atualizar
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(entidade);
        }

        public async Task<Selecao> BuscarPorId(int id)
        {

            return await this._options.BuscarPorId
                                      .SetQueryParam("id", id)
                                      .WithHeader("Cache-Control", "no-cache")
                                      .GetJsonAsync<Selecao>();
        }

        public async Task<IEnumerable<Selecao>> BuscarTodos()
        {
            return await this._options.BuscarTodos
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<Selecao>>();
        }

        public async Task<IEnumerable<Selecao>> BuscarTodosAtivos()
        {
            return await this._options.BuscarTodosAtivo
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<Selecao>>();
        }

        public async Task Remover(int id)
        {
            await this._options.Remover
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(id);
        }
    }
}
