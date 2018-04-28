using CopaDoMundo.Model;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.Servico.Options;
using Flurl;
using Flurl.Http;
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

        public async Task Add(Jogador entidade)
        {
            await this._options.Adicionar
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(entidade);
        }

        public async Task Atualizar(Jogador entidade)
        {
            await this._options.Atualizar
                               .WithHeader("Cache-Control", "no-cache")
                               .PostJsonAsync(entidade);
        }

        public async Task<Jogador> BuscarPorId(int id)
        {
            return await this._options.BuscarPorId
                                     .SetQueryParams(id)
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<Jogador>();
        }

        public async Task<IEnumerable<Jogador>> BuscarTodosAtivos()
        {
            return await this._options.BuscarTodosAtivo
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<Jogador>>();
        }

        public async Task<IEnumerable<Jogador>> BuscarPorSelecao(int selecaoId)
        {
            return await this._options.BuscarPorselecao
                                     .SetQueryParams(selecaoId)
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<Jogador>>();
        }

        public async Task<IEnumerable<Jogador>> BuscarTodos()
        {
            return await this._options.BuscarTodos
                                     .WithHeader("Cache-Control", "no-cache")
                                     .GetJsonAsync<IEnumerable<Jogador>>();
        }

        public async Task Remover(int id)
        {
            await this._options.Remover
                                     .WithHeader("Cache-Control", "no-cache")
                                     .PostJsonAsync(id);
        }
    }
}
