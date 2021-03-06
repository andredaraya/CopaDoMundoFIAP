﻿using AutoMapper;
using CopaDoMundo.Model;
using CopaDoMundo.Web.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CopaDoMundo.Web.Controllers
{

    public class EntidadeBaseController<TServico, TEntidade, TEntidadeViewModel> : Controller
        where TServico : IServicoBase<TEntidade>
        where TEntidade : EntidadeBase

        where TEntidadeViewModel : class
    {
        private readonly TServico _servico;

        public EntidadeBaseController(TServico servico)
        {
            _servico = servico;
        }


        public virtual IActionResult Listar()
        {
            var lista = _servico.BuscarTodos().Result;
            var entidadesMapeadas = Mapper.Map<IEnumerable<TEntidadeViewModel>>(lista);

            return View(entidadesMapeadas);
        }

        public virtual IActionResult Datalhes(int id)
        {
            var entidade = _servico.BuscarPorId(id).Result;
            var entidadeMapeada = Mapper.Map<TEntidadeViewModel>(entidade);

            return View(entidadeMapeada);
        }

        public virtual IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Criar(TEntidadeViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                var entidadeMapeada = Mapper.Map<TEntidade>(entidade);
                entidadeMapeada.CriadoEm = DateTime.Now;
                _servico.Add(entidadeMapeada).Wait();
            }

            return RedirectToAction("Listar");
        }

        // GET: entity/Edit/5
        public virtual IActionResult Editar(int id)
        {
            var entidade = _servico.BuscarPorId(id).Result;
            var entidadeMapeada = Mapper.Map<TEntidadeViewModel>(entidade);

            return View(entidadeMapeada);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Editar(TEntidadeViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                var entidadeMapeada = Mapper.Map<TEntidade>(entidade);
                entidadeMapeada.CriadoEm = DateTime.Now;
                _servico.Atualizar(entidadeMapeada).Wait();
            }

            return RedirectToAction("Listar");
        }

        public IActionResult Deletar(int id)
        {
            var entidade = _servico.BuscarPorId(id).Result;
            var entidadeMapeada = Mapper.Map<TEntidadeViewModel>(entidade);

            return View(entidadeMapeada);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public virtual IActionResult ConfirmarRemover(int id)
        {
            _servico.Remover(id).Wait();
            return RedirectToAction("Listar");
        }
    }
}