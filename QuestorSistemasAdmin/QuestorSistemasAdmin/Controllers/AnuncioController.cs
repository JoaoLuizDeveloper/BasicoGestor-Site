using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasAdmin.Data;
using QuestorSistemasSite.Models;

namespace QuestorSistemasAdmin.Controllers
{
    //[ValidateInput(false)]
    [Authorize]
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

        public IActionResult Create(Anuncio model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //int codCliente = (int)Session["CodCliente"];
            db.Anuncio.Add(model);
            db.Entry(model).State = EntityState.Added;
            

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                    
            }

            return RedirectToAction("Detalhes", "Anuncio", new { Slug = "" });
        }

        public IActionResult Detalhes(int id)
        {
            var anu = db.Anuncio.Find(id);
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var anu = db.Anuncio.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Anuncio model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }

        public IActionResult Excluir(int id)
        {
            var anu = db.Anuncio.Find(id);
            //anu.Excluido = true;
            
            db.Entry(anu).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");   
        }
    }
}
