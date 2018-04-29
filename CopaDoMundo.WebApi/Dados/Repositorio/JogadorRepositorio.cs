using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Dados.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaDoMundo.WebApi.Dados.Repositorio
{
    public class JogadorRepositorio : RepositorioBase, IJogadorRepositorio
    {

        public void DeletaJogadoresPorSelecao(int idSelecao)
        {
            using (var connection = GetConnection())
            {
                var sql = @"DELETE FROM JOGADOR WHERE SELECAO = @IDSELECAO";
                CommandDefinition command = new CommandDefinition(sql, new { idSelecao = idSelecao });

                connection.Open();
                connection.Execute(command);
            }
        }

        public void CadastrarJogador(Jogador jogador)
        {
            jogador.CriadoEm = DateTime.Now;
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute(@"INSERT INTO JOGADOR (NOME, APELIDO, IDADE, POSICAO, SELECAO, CRIADOEM, ATIVO) 
                                    VALUES(@Nome, @Apelido, @Idade, @Posicao, @Selecao, @CriadoEm, @Ativo)", jogador);
            }
        }

        public void AtualizarJogador(Jogador jogador)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute(@"UPDATE JOGADOR 
                                   SET NOME = @Nome,
                                   APELIDO = @Apelido,
                                   IDADE = @Idade,
                                   POSICAO = @Posicao,
                                   SELECAO = @Selecao,
                                   ATIVO = @Ativo
                                   WHERE ID= @ID", jogador);
            }
        }

        public void DeletarJogador(int id)
        {
            using (var connection = GetConnection())
            {
                var sql = @"DELETE FROM JOGADOR WHERE ID = @id";
                CommandDefinition command = new CommandDefinition(sql, new { id = id });

                connection.Open();
                connection.Execute(command);
            }
        }

        public IEnumerable<Jogador> BuscarTodosOsJogadores()
        {
            IList<Jogador> jogadores;
            using (var connection = GetConnection())
            {
                var sql = $@"SELECT * FROM JOGADOR";
                connection.Open();
                jogadores = connection.Query<Jogador>(sql).ToList();
            }

            return jogadores;
        }

        public IEnumerable<Jogador> BuscarTodosOsJogadoresPorSelecao(int idSelecao)
        {
            IList<Jogador> jogadores;
            using (var connection = GetConnection())
            {
                var sql = @"SELECT * FROM JOGADOR WHERE SELECAO = @idSelecao";
                CommandDefinition command = new CommandDefinition(sql, new { idSelecao = idSelecao });

                connection.Open();
                jogadores = connection.Query<Jogador>(command).ToList();
            }

            return jogadores;
        }

        public Jogador BuscarJogadorPorId(int id)
        {
            Jogador jogador = new Jogador();
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"SELECT * FROM JOGADOR WHERE ID = @id";
                CommandDefinition command = new CommandDefinition(sql, new { id = id });

                jogador = connection.Query<Jogador>(command).FirstOrDefault();
            }

            return jogador;
        }
    }
}
