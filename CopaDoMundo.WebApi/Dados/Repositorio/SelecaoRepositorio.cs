using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Dados.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CopaDoMundo.WebApi.Dados.Repositorio
{
    public class SelecaoRepositorio : RepositorioBase, ISelecaoRepositorio
    {
        public void AtualizarSelecao(Selecao model
            )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute($@"update selecao
                                      set Nome = @Nome,
                                      QuantidadeTitulos = @QuantidadeTitulos
                                      where Id = @ID", model);
            }
        }

        public Selecao BuscaSelecaoPorId(int id)
        {
            Selecao resultado;
            using (var connection = GetConnection())
            {
                var sql = $@"select * from selecao  join jogador on selecao.id = jogador.selecao where selecao.id = {id}";
                connection.Open();

                resultado = connection.Query<Selecao, Jogador, Selecao>(sql,
                     (selecao, jogador) =>
                     {
                         selecao.Jogadores = selecao.Jogadores ?? new List<Jogador>();
                         selecao.Jogadores.Add(jogador);
                         return selecao;
                     }).FirstOrDefault();

            }
            return resultado;
        }

        public void CadastrarSelecao(Selecao model)
        {
            model.CriadoEm = DateTime.Now;
            using (var connection = GetConnection())
            {
                connection.Open();

                connection.Execute($"insert into selecao(Nome, QuantidadeTitulos, CriadoEm, Ativo) Values(@Nome, @QuantidadeTitulos, @CriadoEm, @Ativo)", model);


            }
        }

        public void DeletarSelecao(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                connection.Execute($"delete from selecao where id = {id}");
            }
        }

        public IList<Selecao> ListaSelecoes()
        {
            IList<Selecao> resultado;
            using (var connection = GetConnection())
            {
                var sql = $@"select * from selecao ";
                connection.Open();

                resultado = connection.Query<Selecao>(sql).ToList();

            }
            return resultado;
        }
    }
}
