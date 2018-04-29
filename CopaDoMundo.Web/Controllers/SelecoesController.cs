using AutoMapper;
using CopaDoMundo.Model;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Controllers
{
    public class SelecoesController : EntidadeBaseController<ISelecaoServico, Selecao, SelecaoViewModel>
    {
        private readonly ISelecaoServico _servico;
        private readonly IJogadorServico _jogadorServico;

        public SelecoesController(ISelecaoServico servico, IJogadorServico jogadorServico) : base(servico)
        {
            _servico = servico;
            _jogadorServico = jogadorServico;
        }

        public override IActionResult Editar(int id)
        {
            var selecao = _servico.BuscarPorId(id).Result;
            var selecaoMapeada = Mapper.Map<SelecaoViewModel>(selecao);

            var jogadores = _jogadorServico.BuscarPorSelecao(id).Result;
            var jogadoresMapeados = Mapper.Map<List<JogadorViewModel>>(jogadores);
            selecaoMapeada.Jogadores = jogadoresMapeados;

            return View(selecaoMapeada);
        }
    }
}