using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Servico;
using Microsoft.AspNetCore.Mvc;

namespace CopaDoMundo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class JogadorController : Controller
    {
        JogadorServico servico;

        public JogadorController()
        {
            servico = new JogadorServico();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Jogador> Get()
        {
            return servico.RetornaTodosJogadores();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Jogador Get(int id)
        {
            return servico.RetornaJogadorPorId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Jogador value)
        {
            servico.CadastrarSelecao(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Jogador value)
        {
            value.ID = id;
            servico.AtualizarJogador(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            servico.DeletarJogador(id);
        }
    }
}
