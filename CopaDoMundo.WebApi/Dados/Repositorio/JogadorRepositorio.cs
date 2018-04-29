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

        public void DeletaJogadoresPorSelecao(int idSelecao)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                connection.Execute($"delete from jogador where selecao = {idSelecao}");
            }
        }

        public void CadastrarJogador(Jogador jogador)
        {
            jogador.CriadoEm = DateTime.Now;
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute($"insert into jogador (Nome, Apelido, Idade, Posicao, Selecao, CriadoEm, Ativo) Values(@Nome, @Apelido, @Idade, @Posicao, @Selecao, @CriadoEm, @Ativo)", jogador);
            }
        }

        public void AtualizarJogador(Jogador jogador)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute($@"update jogador 
                                   SET Nome = @Nome,
                                   Apelido = @Apelido,
                                   Idade = @Idade,
                                   Posicao = @Posicao,
                                   Selecao = @Selecao,
                                   Ativo = @Ativo
                                   Where Id= @ID", jogador);
            }
        }

        public void DeletarJogador(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute($"DELETE FROM JOGADOR WHERE ID = {id}");
            }
        }

        public IEnumerable<Jogador> BuscarTodosOsJogadores()
        {
            IList<Jogador> jogadores;
            using (var connection = GetConnection())
            {
                var sql = $@"select * from jogador";
                connection.Open();
                jogadores = connection.Query<Jogador>(sql).ToList();
            }

            return jogadores;
        }

        public Jogador BuscarJogadorPorId(int id)
        {
            Jogador jogador = new Jogador();
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = $"select * from jogador where Id = {id}";

                jogador = connection.Query<Jogador>(sql).FirstOrDefault();
            }

            return jogador;
        }
    }
}
