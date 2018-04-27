using AutoMapper;
using CopaDoMundo.Web.Servico.DTO;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Controllers
{
    public class SelecoesController : EntidadeBaseController<ISelecaoServico, SelecaoDTO, SelecaoViewModel>
    {
        private readonly ISelecaoServico _servico;
        private readonly IJogadorServico _jogadorServico;

        public SelecoesController(ISelecaoServico servico, IJogadorServico jogadorServico) : base(servico)
        {
            _servico = servico;
            _jogadorServico = jogadorServico;
        }

        public IActionResult Index(int id)
        {
            var selecao = _servico.BuscarPorId(id);
            var selecaoMapeada = Mapper.Map<SelecaoViewModel>(selecao);

            var jogadores = _jogadorServico.BuscarPorSelecao(id);
            var jogadoresMapeados = Mapper.Map<List<JogadorViewModel>>(jogadores);
            selecaoMapeada.Jogadores = jogadoresMapeados;

            return View(selecaoMapeada);
        }
    }
}