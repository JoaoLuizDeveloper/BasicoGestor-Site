using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasAdmin.Data;
using QuestorSistemasAdmin.Models;

namespace QuestorSistemasAdmin.Controllers
{
    [Authorize]
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
            var model = db.Marca.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Marca model, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region Imagem
                    string VirtualPathTemp = ".\\wwwroot\\Conteudo\\Marcas\\";
                    string VirtualPathSite = "C:\\Users\\JuninhoDRZ\\source\\ProjetoQuestorSistemas\\ProjetoQuestorSistemas\\QuestorSistemasSite\\QuestorSistemasSite\\wwwroot\\Conteudo\\Marcas\\";

                    if (Imagem != null)
                    {
                        string ext = "";
                        ext = System.IO.Path.GetExtension(Imagem.FileName).ToLower();

                        string[] extensions = { ".jpg", ".jpeg", ".png", ".gif" };
                        if (!extensions.Contains(ext.ToLower()))
                        {
                            ModelState.AddModelError("", "O  arquivo enviado não possui o formato correto. Somente imagens JPG, PNG ou GIF!");
                        }

                        var ticks = DateTime.Now.Ticks.ToString();
                        string saveName = VirtualPathTemp + ticks + Imagem.FileName;
                        string saveNameSite = VirtualPathSite + ticks + Imagem.FileName;
                        if (!Directory.Exists(VirtualPathTemp))
                        {
                            Directory.CreateDirectory(VirtualPathTemp);
                        }

                        if (!Directory.Exists(VirtualPathSite))
                        {
                            Directory.CreateDirectory(VirtualPathSite);
                        }

                        using (var stream = new FileStream(saveName, FileMode.Create))
                        {
                            Imagem.CopyTo(stream);
                        }

                        using (var stream = new FileStream(saveNameSite, FileMode.Create))
                        {
                            Imagem.CopyTo(stream);
                        }
                        model.Imagem = ticks + Imagem.FileName;
                    }
                    #endregion

                    model.DataCadastro = DateTime.Now;
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();

                    return RedirectToAction("Detalhes", "Marca", new { id = model.Id });
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }


        public IActionResult Detalhes(int id)
        {
            var model = db.Marca.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var model = db.Marca.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(Marca model, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region Imagem
                    string VirtualPathTemp = ".\\wwwroot\\Conteudo\\Marcas\\";
                    string VirtualPathSite = "C:\\Users\\JuninhoDRZ\\source\\ProjetoQuestorSistemas\\ProjetoQuestorSistemas\\QuestorSistemasSite\\QuestorSistemasSite\\wwwroot\\Conteudo\\Marcas\\";

                    if (Imagem != null)
                    {
                        string ext = "";
                        ext = System.IO.Path.GetExtension(Imagem.FileName).ToLower();

                        string[] extensions = { ".jpg", ".jpeg", ".png", ".gif" };
                        if (!extensions.Contains(ext.ToLower()))
                        {
                            ModelState.AddModelError("", "O  arquivo enviado não possui o formato correto. Somente imagens JPG, PNG ou GIF!");
                        }

                        var ticks = DateTime.Now.Ticks.ToString();
                        string saveName = VirtualPathTemp + ticks + Imagem.FileName;
                        string saveNameSite = VirtualPathSite + ticks + Imagem.FileName;
                        if (!Directory.Exists(VirtualPathTemp))
                        {
                            Directory.CreateDirectory(VirtualPathTemp);
                        }

                        if (!Directory.Exists(VirtualPathSite))
                        {
                            Directory.CreateDirectory(VirtualPathSite);
                        }

                        using (var stream = new FileStream(saveName, FileMode.Create))
                        {
                            Imagem.CopyTo(stream);
                        }

                        using (var stream = new FileStream(saveNameSite, FileMode.Create))
                        {
                            Imagem.CopyTo(stream);
                        }
                        model.Imagem = ticks + Imagem.FileName;
                    }
                    #endregion

                    model.DataCadastro = DateTime.Now;                    
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Detalhes", "Marca", new { id = model.Id });
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }

        public IActionResult Excluir(int id)
        {
            var model = db.Marca.Find(id);
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Marca");
        }
    }
}
