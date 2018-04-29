using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Dados.Repositorio;
using System.Collections.Generic;

namespace CopaDoMundo.WebApi.Servico
{
    public class JogadorServico
    {
        JogadorRepositorio _repo;

        public JogadorServico()
        {
            _repo = new JogadorRepositorio();
        }

        public void CadastrarJogador(Jogador model)
        {            
            _repo.CadastrarJogador(model);
        }

        public void AtualizarJogador(Jogador model)
        {
            
            _repo.AtualizarJogador(model);
        }

        public void DeletarJogador(int id)
        {
            
            _repo.DeletarJogador(id);
        }

        public IEnumerable<Jogador> RetornaTodosJogadores()
        {            
            return _repo.BuscarTodosOsJogadores();
        }

        public IEnumerable<Jogador> RetornarPorSelecao(int idSelecao)
        {
            return _repo.BuscarTodosOsJogadoresPorSelecao(idSelecao);
        }

        public Jogador RetornaJogadorPorId(int id)
        {
            return _repo.BuscarJogadorPorId(id);
        }
    }
}
