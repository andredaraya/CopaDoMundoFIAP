using CopaDoMundo.Web.Models;
using CopaDoMundo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace CopaDoMundo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<SelecaoViewModel> selecoes = new List<SelecaoViewModel>();

            return View(selecoes);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
