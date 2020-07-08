using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestorSistemasAdmin.Data;
using QuestorSistemasAdmin.Models;

namespace QuestorSistemasAdmin.Controllers
{
    public class ContatoController : Controller
    {
        private ApplicationDbContext db;
        public static List<Contato> Contato = null;

        public ContatoController(ApplicationDbContext contexto)
        {
            db = contexto;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
