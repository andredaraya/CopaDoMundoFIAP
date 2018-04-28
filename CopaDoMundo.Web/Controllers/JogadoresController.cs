using AutoMapper;
using CopaDoMundo.Model;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CopaDoMundo.Web.Controllers
{
    public class JogadoresController : EntidadeBaseController<IJogadorServico, Jogador, JogadorViewModel>
    {
        private readonly IJogadorServico _jogadorServico;
        private readonly ISelecaoServico _selecaoServico;
        private static List<SelecaoViewModel> _selecoes;
        public JogadoresController(IJogadorServico jogadorServico, ISelecaoServico selecaoServico) : base(jogadorServico)
        {
            _jogadorServico = jogadorServico;
            _selecaoServico = selecaoServico;
        }

        public override IActionResult Criar()
        {
            JogadorViewModel model = new JogadorViewModel();

            model.Selecoes = Mapper.Map<List<SelecaoViewModel>>(_selecaoServico.BuscarTodosAtivos().Result);
            _selecoes = model.Selecoes;

            return View(model);
        }

        public override IActionResult Criar(JogadorViewModel entidade)
        {
            entidade.Selecao = _selecoes.Where(s => s.ID == entidade.SelecaoEscolhida).SingleOrDefault();
            return base.Criar(entidade);
        }

        public IActionResult Index(int id)
        {
            var jogador = _jogadorServico.BuscarPorId(id);
            var jogadorMapeado = Mapper.Map<JogadorViewModel>(jogador);

            return View(jogadorMapeado);
        }
    }
}