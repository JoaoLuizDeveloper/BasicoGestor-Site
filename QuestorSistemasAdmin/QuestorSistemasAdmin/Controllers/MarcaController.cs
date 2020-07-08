using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasAdmin.Data;
using QuestorSistemasAdmin.Models;

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
                    if (Imagem != null)
                    {
                        long size = Imagem.Length;
                        string VirtualPathTemp = Path.GetTempFileName();
                        //string VirtualPathTemp = "C:\\Conteudo\\Anuncios\\Imagem";
                        string ext = "";
                        ext = System.IO.Path.GetExtension(Imagem.FileName).ToLower();

                        string[] extensions = { ".jpg", ".jpeg", ".png", ".gif" };
                        if (!extensions.Contains(ext.ToLower()))
                        {
                            ModelState.AddModelError("", "O  arquivo enviado não possui o formato correto. Somente imagens JPG, PNG ou GIF!");
                        }

                        string saveName = VirtualPathTemp + Imagem.FileName;
                        //if (!Directory.Exists(VirtualPathTemp))
                        //{
                        //    Directory.CreateDirectory(VirtualPathTemp);
                        //}

                        using (var stream = new FileStream(VirtualPathTemp, FileMode.Create))
                        {
                            Imagem.CopyToAsync(stream);
                        }
                    }
                    #endregion

                    model.DataCadastro = DateTime.Now;

                    model.Imagem = Path.GetTempFileName() + "\\" + Imagem.FileName;

                    db.Marca.Add(model);
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();

                    return RedirectToAction("Detalhes", "Anuncio", new { id = model.Id });
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }


        public IActionResult Detalhes(int id)
        {
            var model = db.Anuncio.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var model = db.Anuncio.FirstOrDefault(x => x.Id == id);
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
                    if (Imagem != null)
                    {
                        long size = Imagem.Length;
                        string VirtualPathTemp = Path.GetTempFileName();
                        //string VirtualPathTemp = "C:\\Conteudo\\Anuncios\\Imagem";
                        string ext = "";
                        ext = System.IO.Path.GetExtension(Imagem.FileName).ToLower();

                        string[] extensions = { ".jpg", ".jpeg", ".png", ".gif" };
                        if (!extensions.Contains(ext.ToLower()))
                        {
                            ModelState.AddModelError("", "O  arquivo enviado não possui o formato correto. Somente imagens JPG, PNG ou GIF!");
                        }

                        string saveName = VirtualPathTemp + Imagem.FileName;
                        //if (!Directory.Exists(VirtualPathTemp))
                        //{
                        //    Directory.CreateDirectory(VirtualPathTemp);
                        //}

                        using (var stream = new FileStream(VirtualPathTemp, FileMode.Create))
                        {
                            Imagem.CopyToAsync(stream);
                        }
                    }
                    #endregion

                    model.DataCadastro = DateTime.Now;

                    model.Imagem = Path.GetTempFileName() + "\\" + Imagem.FileName;

                    db.Marca.Add(model);
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Detalhes", "Anuncio", new { id = model.Id });
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }

        public IActionResult Excluir(int id)
        {
            var model = db.Marca.Find(id);
            //anu.Excluido = true;

            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
