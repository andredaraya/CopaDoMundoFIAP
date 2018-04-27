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
    public class JogadorServico : IJogadorServico
    {
        private readonly JogadorOptions _options;

        public JogadorServico(JogadorOptions options)
        {
            this._options = options;
        }

        public async Task Add(JogadorDTO entidade)
        {
            await this._options.Adicionar
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(entidade);
        }

        public async Task Atualizar(JogadorDTO entidade)
        {
            await this._options.Atualizar
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(entidade);
        }

        public async Task<JogadorDTO> BuscarPorId(int id)
        {
            return await this._options.BuscarPorId
                                     .SetQueryParams(id)
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<JogadorDTO>();
        }

        public async Task<IEnumerable<JogadorDTO>> BuscarTodosAtivos()
        {
            return await this._options.BuscarTodosAtivo
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<JogadorDTO>>();
        }

        public async Task<IEnumerable<JogadorDTO>> BuscarPorSelecao(int selecaoId)
        {
            List<JogadorDTO> listTemp = new List<JogadorDTO>();
            listTemp.Add(new JogadorDTO()
            {
                ID = 1,
                Nome = "Alejo",
                Apelido = "Gornaldo",
                Idade = 35,
                Posicao = "Centro Avante", //descrição que virá do banco
                Ativo = true,
                CriadoEm = DateTime.Now,
                Selecao = 1

            });

            listTemp.Add(new JogadorDTO()
            {
                ID = 2,
                Nome = "Garrincha",
                Apelido = "Torto",
                Idade = 90,
                Posicao = "Centro Avante", //descrição que virá do banco
                Ativo = true,
                CriadoEm = DateTime.Now,
                Selecao = 1

            });

            return listTemp;

            return await this._options.BuscarPorselecao
                                     .SetQueryParams(selecaoId)
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<JogadorDTO>>();
        }

        public async Task<IEnumerable<JogadorDTO>> BuscarTodos()
        {
            return await this._options.BuscarTodos
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<JogadorDTO>>();
        }

        public async Task Remover(int id)
        {
            await this._options.Remover
                                     .WithHeader("Cache-Control", "no-cache")
                                     .PostJsonAsync(id);
        }
    }
}
