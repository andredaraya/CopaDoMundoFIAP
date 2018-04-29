using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Dados.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CopaDoMundo.WebApi.Dados.Repositorio
{
    public class JogadorRepositorio : RepositorioBase, IJogadorRepositorio
    {
        public IList<Jogador> BuscaJogadoresPorSelecao(int idSelecao)
        {
            throw new NotImplementedException();
        }

        public void DeletaJogadoresPorSelecao(int idSelecao)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                connection.Execute($"delete from jogador where selecao = {idSelecao}");
            }
        }
    }
}
