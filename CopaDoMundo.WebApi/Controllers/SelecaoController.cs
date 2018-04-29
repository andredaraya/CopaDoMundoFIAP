using CopaDoMundo.Model;
using CopaDoMundo.WebApi.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaDoMundo.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Selecao")]
    public class SelecaoController : Controller
    {
        // GET: api/Selecao
        [HttpGet]
        [Route("buscarTodos")]
        public IList<Selecao> Get()
        {
            var servico = new SelecaoServico();
            return servico.ListarSelecoes();
        }

        // GET: api/Selecao/5
        [HttpGet]
        [Route("buscarPorId")]
        public Selecao Get([FromQuery] int id)
        {
            var servico = new SelecaoServico();
            return servico.BuscaSelecaoPorId(id);
        }

        // POST: api/Selecao
        [HttpPost]
        [Route("adicionar")]
        public void Post([FromBody]Selecao value)
        {
            var servico = new SelecaoServico();
            servico.CadastrarSelecao(value);
        }

        // PUT: api/Selecao/5
        [HttpPost]
        [Route("atualizar")]
        public void Put([FromBody]Selecao value)
        {
            //value.ID = id;
            var servico = new SelecaoServico();
            servico.AtualizarSelecao(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("remover")]
        public void Delete([FromBody] int id)
        {
            var servico = new SelecaoServico();
            servico.DeletarSelecao(id);
        }
    }
}
