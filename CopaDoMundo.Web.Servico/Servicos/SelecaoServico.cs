using CopaDoMundo.Web.Servico.DTO;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.Servico.Options;
using Flurl;
using Flurl.Http;
using System;
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

        public async Task Add(SelecaoDTO entidade)
        {
            await this._options.Adicionar
                                .WithHeader("Cache-Control", "no-cache")
                                .PostJsonAsync(entidade);
        }

        public async Task Atualizar(SelecaoDTO entidade)
        {
            await this._options.Atualizar
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(entidade);
        }

        public async Task<SelecaoDTO> BuscarPorId(int id)
        {
            return await this._options.BuscarPorId
                                      .SetQueryParams(id)
                                      .WithHeader("Cache-Control", "no-cache")
                                      .GetJsonAsync<SelecaoDTO>();
        }

        public async Task<IEnumerable<SelecaoDTO>> BuscarTodos()
        {
            return await this._options.BuscarTodos
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<SelecaoDTO>>();
        }

        public async Task<IEnumerable<SelecaoDTO>> BuscarTodosAtivos()
        {
            List<SelecaoDTO> listTEmp = new List<SelecaoDTO>();
            listTEmp.Add(new SelecaoDTO()
            {
                ID = 1,
                Ativo = true,
                CriadoEm = DateTime.Now,
                Nome = "Brasil",
                QuantidadeTitulos = 5
            });

            return listTEmp;

            return await this._options.BuscarTodosAtivo
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<SelecaoDTO>>();
        }

        public async Task Remover(int id)
        {
            await this._options.Remover
                                     .WithHeader("Cache-Control", "no-cache")
                                     .PostJsonAsync(id);
        }
    }
}
