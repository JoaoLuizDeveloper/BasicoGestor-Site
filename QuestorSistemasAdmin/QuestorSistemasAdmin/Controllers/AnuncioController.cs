using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuestorSistemasAdmin.Data;
using QuestorSistemasAdmin.Enums;
using QuestorSistemasAdmin.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using QuestorSistemasAdmin.ViewModel;

namespace QuestorSistemasAdmin.Controllers
{
    [Authorize]
    public class AnuncioController : Controller
    {
        private ApplicationDbContext db;
        public static List<Anuncio> Anuncio = null;

        public AnuncioController(ApplicationDbContext contexto)
        {
            db = contexto;
        }

        public IActionResult Index(string Inicial = "", string Final = "")
        {
            var model = db.Anuncio.Where(x => x.Ativo).ToList();
            if(!string.IsNullOrEmpty(Inicial))
            {
                model = model.Where(x => x.DataVenda >= Convert.ToDateTime(Inicial)).ToList();
                ViewBag.Inicial = Inicial;
            }
            
            if(!string.IsNullOrEmpty(Final))
            {
                model = model.Where(x => x.DataVenda <= Convert.ToDateTime(Final)).ToList();
                ViewBag.Final = Final;
            }

            return View(model);
        }

        public IActionResult Create ()
        {
            ViewBag.Marca = db.Marca.ToList().Select(u => new SelectListItem()
            {
                Text = u.MarcaVeiculo,
                Value = u.Id.ToString()
            }).ToList<SelectListItem>();

            ViewBag.Modelos = db.Modelo.ToList();

            ViewBag.TipoCombustivel = new SelectList(Enum.GetValues(typeof(TipoCombustivel)).Cast<TipoCombustivel>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            ViewBag.Portas = new SelectList(Enum.GetValues(typeof(Portas)).Cast<Portas>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Anuncio model, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region Imagem
                    if (Imagem != null)
                    {
                        string VirtualPathTemp = ".\\wwwroot\\Conteudo\\Anuncios\\";
                        string VirtualPathSite = "C:\\Users\\JuninhoDRZ\\source\\ProjetoQuestorSistemas\\ProjetoQuestorSistemas\\QuestorSistemasSite\\QuestorSistemasSite\\wwwroot\\Conteudo\\Anuncios\\";

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

                    if (ModelState.IsValid)
                    {
                        if (string.IsNullOrEmpty(model.Slug))
                        {
                            model.Slug = model.Marca.ToLower() + model.Modelo.ToLower();
                            model.Slug = Regex.Replace(model.Slug, @"\s+", " ").Trim();
                            model.Slug = Regex.Replace(model.Slug, @"\s", "-");
                            model.Slug = Regex.Replace(model.Slug, @"<p>", "");
                            model.Slug = Regex.Replace(model.Slug, @"</p>", "");
                            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(model.Slug);
                            model.Slug = System.Text.Encoding.ASCII.GetString(bytes);
                        }
                        model.DataVenda = DateTime.Now;
                        model.Marca = db.Marca.Find(model.Marca).MarcaVeiculo;
                        model.Modelo = db.Modelo.Find(model.Modelo).Nome;
                        db.Entry(model).State = EntityState.Added;
                        db.SaveChanges();

                        return RedirectToAction("Detalhes", "Anuncio", new { Slug = model.Slug });
                    }
                    return View(model);
                }
                catch (Exception e)
                { 
                    return View(model);                
                }
            }
            
            return View(model);
        }
        
        public IActionResult Detalhes(string Slug)
        {
            var model = db.Anuncio.FirstOrDefault(x=> x.Slug == Slug);
            return View(model);
        }

        public IActionResult Editar(string Slug)
        {
            ViewBag.TipoCombustivel = new SelectList(Enum.GetValues(typeof(TipoCombustivel)).Cast<TipoCombustivel>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            ViewBag.Portas = new SelectList(Enum.GetValues(typeof(Portas)).Cast<Portas>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            var model = db.Anuncio.FirstOrDefault(x => x.Slug == Slug);
            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(Anuncio model, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region Imagem
                    if (Imagem != null)
                    {
                        string VirtualPathTemp = ".\\wwwroot\\Conteudo\\Anuncios\\";
                        string VirtualPathSite = "C:\\Users\\JuninhoDRZ\\source\\ProjetoQuestorSistemas\\ProjetoQuestorSistemas\\QuestorSistemasSite\\QuestorSistemasSite\\wwwroot\\Conteudo\\Anuncios\\";

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

                    if (ModelState.IsValid)
                    {
                        db.Entry(model).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Detalhes", "Anuncio", new { Slug = model.Slug });
                    }

                    return View(model);
                }
                catch (Exception e)
                { }
            }

            return View(model);
        }

        public IActionResult Excluir(int id)
        {
            var model = db.Anuncio.Find(id);            
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Anuncio");   
        }

        [HttpPost]
        public async Task<IActionResult> EnviarImagem(IFormFile Imagem)
        {
            long size = Imagem.Length;
            string VirtualPathTemp = "~/Conteudo/Anuncios/Images/";
            string ext = "";
            ext = System.IO.Path.GetExtension(Imagem.FileName).ToLower();

            string[] extensions = { ".jpg", ".jpeg", ".png", ".gif" };
            if (!extensions.Contains(ext.ToLower()))
            {
                ModelState.AddModelError("", "O  arquivo enviado não possui o formato correto. Somente imagens JPG, PNG ou GIF!");
            }

            string saveName = VirtualPathTemp + Imagem.FileName + ext;
            if (!Directory.Exists(VirtualPathTemp))
            {
                Directory.CreateDirectory(VirtualPathTemp);
            }

            using (var stream = new FileStream(VirtualPathTemp, FileMode.Create))
            {
                await Imagem.CopyToAsync(stream);
            }

            return Ok(new { saveName, size });
        }

        [HttpGet]
        public IActionResult Print(string Inicial = "", string Final = "")
        {
            var model = db.Anuncio.Where(x => x.Ativo).ToList();
            if (!string.IsNullOrEmpty(Inicial))
            {
                model = model.Where(x => x.DataVenda >= Convert.ToDateTime(Inicial)).ToList();
                ViewBag.Inicial = Inicial;
            }

            if (!string.IsNullOrEmpty(Final))
            {
                model = model.Where(x => x.DataVenda <= Convert.ToDateTime(Final)).ToList();
                ViewBag.Final = Final;
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Pdf(string Inicial = "", string Final = "")
        {
            var model = db.Anuncio.Where(x => x.Ativo).ToList();
            if (!string.IsNullOrEmpty(Inicial))
            {
                model = model.Where(x => x.DataVenda >= Convert.ToDateTime(Inicial)).ToList();
                ViewBag.Inicial = Inicial;
            }

            if (!string.IsNullOrEmpty(Final))
            {
                model = model.Where(x => x.DataVenda <= Convert.ToDateTime(Final)).ToList();
                ViewBag.Final = Final;
            }

            return View(model);
        }

        [HttpPost]
        public JsonResult SearchMarca(string id)
        {
            var data = db.Modelo.Where(c => c.Idmarca == Int32.Parse(id)).ToList();
            var m = Json(data);
            
            return Json(data);            
        }
    }
}
