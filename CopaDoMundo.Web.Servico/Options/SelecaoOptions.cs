using Flurl;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Servico.Options
{
    public class SelecaoOptions
    {
        public const string SectionName = "ServicoSelecao";

        public string Endpoint { get; private set; }
        public string Adicionar { get; private set; }
        public string Atualizar { get; private set; }
        public string BuscarPorId { get; private set; }
        public string BuscarTodos { get; private set; }
        public string BuscarTodosAtivo { get; private set; }
        public string Remover { get; private set; }

        public SelecaoOptions(IConfiguration configuration)
        {
            var section = configuration.GetSection(SectionName);
            var endpoint = section["Endpoint"];

            var adicionar = section["Adicionar"];
            var atualizar = section["Atualizar"];
            var buscarPorId = section["BuscarPorId"];
            var buscarTodos = section["BuscarTodos"];
            var buscarTodosAtivo = section["BuscarTodosAtivo"];
            var remover = section["Remover"];

            ValidateConfiguration(endpoint);
            ValidateConfiguration(adicionar);
            ValidateConfiguration(atualizar);
            ValidateConfiguration(buscarPorId);
            ValidateConfiguration(buscarTodos);
            ValidateConfiguration(buscarTodosAtivo);
            ValidateConfiguration(remover);

            this.Endpoint = endpoint;
            this.Adicionar = Url.Combine(endpoint, adicionar);
            this.Atualizar = Url.Combine(endpoint, atualizar);
            this.BuscarPorId = Url.Combine(endpoint, buscarPorId);
            this.BuscarTodos = Url.Combine(endpoint, buscarTodos);
            this.BuscarTodosAtivo = Url.Combine(endpoint, buscarTodosAtivo);
            this.Remover = Url.Combine(endpoint, remover);
        }

        private static void ValidateConfiguration(string chave)
        {
            if (string.IsNullOrWhiteSpace(chave))
                throw new KeyNotFoundException($"Config key {SectionName}: {chave} não definido.");
                
        }
    }
}
