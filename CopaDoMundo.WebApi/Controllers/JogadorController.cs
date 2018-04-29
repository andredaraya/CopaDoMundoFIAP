using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaDoMundo.WebApi.Controllers
{
    [Route("api/Jogador")]
    public class JogadorController : Controller
    {
        JogadorServico servico;

        public JogadorController()
        {
            servico = new JogadorServico();
        }

        // GET api/values
        [HttpGet]
        [Route("buscarTodos")]
        public IEnumerable<Jogador> Get()
        {
            return servico.RetornaTodosJogadores();
        }

        [HttpGet]
        [Route("buscarPorSelecao")]
        public IEnumerable<Jogador> BuscarPorSelecao([FromQuery] int idSelecao)
        {
            return servico.RetornarPorSelecao(idSelecao);
        }

        // GET api/values/5
        [HttpGet]
        [Route("buscarPorId")]
        public Jogador Get([FromQuery] int id)
        {
            return servico.RetornaJogadorPorId(id);
        }

        // POST api/values
        [HttpPost]
        [Route("adicionar")]
        public void Post([FromBody]Jogador value)
        {
            servico.CadastrarJogador(value);
        }

        // PUT api/values/5
        [HttpPost]
        [Route("atualizar")]
        public void Put([FromBody]Jogador value)
        {
            //value.ID = id;
            servico.AtualizarJogador(value);
        }

        // DELETE api/values/5
        [HttpPost]
        [Route("remover")]
        public void Delete([FromBody] int id)
        {
            servico.DeletarJogador(id);
        }
    }
}
