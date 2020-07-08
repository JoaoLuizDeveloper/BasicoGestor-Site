using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestorSistemasSite.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnuncioController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AnuncioController> _logger;

        public AnuncioController(ILogger<AnuncioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Anuncio> Get()
        {
            var rng = new List<Anuncio>();
            //return Enumerable.Range(1, 5).Select(index => new Anuncio
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            return rng;
        }
    }
}
