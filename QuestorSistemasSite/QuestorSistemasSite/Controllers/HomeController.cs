using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestorSistemasSite.Models;

namespace QuestorSistemasSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;
        public static List<Anuncio> Anuncio = null;
        public static List<Marca> Marca = null;
        public static List<Modelo> Modelo = null;

        public HomeController(ApplicationDbContext contexto, ILogger<HomeController> logger)
        {
            db = contexto;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Anuncio = Anuncio = db.Anuncio.Where(x => x.Ativo).ToList();
            ViewBag.Marcas = Marca = db.Marca.ToList();
            ViewBag.Modelos = Modelo = db.Modelo.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
