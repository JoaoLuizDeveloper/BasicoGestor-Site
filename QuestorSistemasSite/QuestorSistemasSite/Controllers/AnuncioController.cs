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
            return View();
        }
    }
}
