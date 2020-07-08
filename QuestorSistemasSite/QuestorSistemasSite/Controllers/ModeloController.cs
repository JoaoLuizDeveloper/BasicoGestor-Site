using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestorSistemasSite.Models;

namespace QuestorSistemasSite.Controllers
{
    public class ModeloController : Controller
    {
        private ApplicationDbContext db;
        public static List<Modelo> Modelo = null;

        public ModeloController(ApplicationDbContext contexto)
        {
            db = contexto;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
