using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Dados.Repositorio;
using CopaDoMundo.WebApi.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaDoMundo.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Selecao")]
    public class SelecaoController : Controller
    {
        // GET: api/Selecao
        [HttpGet]
        public IList<Selecao> Get()
        {
            var servico = new SelecaoServico();
            return servico.ListarSelecoes();
        }

        // GET: api/Selecao/5
        [HttpGet("{id}", Name = "Get")]
        public Selecao Get(int id)
        {
            var servico = new SelecaoServico();
            return servico.BuscaSelecaoPorId(id);
        }

        // POST: api/Selecao
        [HttpPost]
        public void Post([FromBody]Selecao value)
        {
            var servico = new SelecaoServico();
            servico.CadastrarSelecao(value);
        }

        // PUT: api/Selecao/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Selecao value)
        {
            value.ID = id;
            var servico = new SelecaoServico();
            servico.AtualizarSelecao(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var servico = new SelecaoServico();
            servico.DeletarSelecao(id);
        }
    }
}
