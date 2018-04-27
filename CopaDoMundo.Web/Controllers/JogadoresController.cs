using AutoMapper;
using CopaDoMundo.Web.Servico.DTO;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CopaDoMundo.Web.Controllers
{
    public class JogadoresController :  EntidadeBaseController<IJogadorServico, JogadorDTO, JogadorViewModel>
    {
        private readonly IJogadorServico _jogadorServico;

        public JogadoresController(IJogadorServico jogadorServico) : base(jogadorServico)
        {
            _jogadorServico = jogadorServico;
        }


        public IActionResult Index(int id)
        {
            var jogador = _jogadorServico.BuscarPorId(id);
            var jogadorMapeado = Mapper.Map<JogadorViewModel>(jogador);

            return View(jogadorMapeado);
        }
    }
}