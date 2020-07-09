using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasAdmin.Data;
using QuestorSistemasAdmin.Models;

namespace QuestorSistemasAdmin.Controllers
{
    [Authorize]
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
            var model = db.Contato.ToList();
            return View(model);
        }
          
        public IActionResult Detalhes(int id)
        {
            var model = db.Contato.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        
        public IActionResult Excluir(int id)
        {
            var model = db.Contato.Find(id);
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Contato");
        }
    }
}
