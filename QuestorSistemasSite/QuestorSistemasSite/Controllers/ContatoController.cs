using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasSite.Models;

namespace QuestorSistemasSite.Controllers
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
        [HttpPost]
        public async Task<ActionResult> Index(string Nome, string Email, string Descricao)
        {
            var model = new Contato();
            if (!string.IsNullOrEmpty(Nome) && !string.IsNullOrEmpty(Email))
            {
                
                model.Nome = Nome;
                model.Email = Email;
                model.Descricao = Descricao;
                model.DataCadastro = DateTime.Now;

                db.Entry(model).State = EntityState.Added;
                db.SaveChanges();
            }
            var a = Json(new { success = true, model });

            return Json(model);
        }
    }
}
