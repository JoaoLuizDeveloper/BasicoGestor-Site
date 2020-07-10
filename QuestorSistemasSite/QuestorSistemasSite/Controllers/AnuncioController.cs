using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestorSistemasSite.Models;

namespace QuestorSistemasSite.Controllers
{
    public class AnuncioController : Controller
    {
        private ApplicationDbContext db;
        public static List<Anuncio> Anuncio = null;

        public AnuncioController(ApplicationDbContext contexto)
        {
            db = contexto;
        }

        public IActionResult Index()
        {
            var model = db.Anuncio.Where(x=> x.Ativo).ToList();
            return View(model);
        }

        public IActionResult Detalhes(string Slug)
        {
            var model = db.Anuncio.FirstOrDefault(x => x.Slug == Slug);
            ViewBag.Before = db.Anuncio.FirstOrDefault(x => x.Id == model.Id - 1) != null ? db.Anuncio.FirstOrDefault(x => x.Id == model.Id - 1).Slug : model.Slug;
            ViewBag.After = db.Anuncio.FirstOrDefault(x => x.Id == model.Id + 1) != null ? db.Anuncio.FirstOrDefault(x => x.Id == model.Id + 1).Slug : model.Slug;
            return View(model);
        }
    }
}
