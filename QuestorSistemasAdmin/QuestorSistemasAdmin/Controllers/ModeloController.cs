using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasAdmin.Data;
using QuestorSistemasAdmin.Models;

namespace QuestorSistemasAdmin.Controllers
{
    [Authorize]
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
            var model = db.Modelo.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Modelo model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.DataCadastro = DateTime.Now;
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();

                    return RedirectToAction("Detalhes", "Modelo", new { id = model.Id });
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }


        public IActionResult Detalhes(int id)
        {
            var model = db.Modelo.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var model = db.Modelo.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(Modelo model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.DataCadastro = DateTime.Now;
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Detalhes", "Modelo", new { id = model.Id });
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }

        public IActionResult Excluir(int id)
        {
            var model = db.Modelo.Find(id);
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Modelo");
        }
    }
}
