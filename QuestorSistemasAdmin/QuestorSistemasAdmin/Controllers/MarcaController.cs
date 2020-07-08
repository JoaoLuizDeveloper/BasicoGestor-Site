using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestorSistemasAdmin.Data;
using QuestorSistemasSite.Models;

namespace QuestorSistemasAdmin.Controllers
{
    public class MarcaController : Controller
    {
        private ApplicationDbContext db;
        public static List<Marca> Marca = null;

        public MarcaController(ApplicationDbContext contexto)
        {
            db = contexto;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
