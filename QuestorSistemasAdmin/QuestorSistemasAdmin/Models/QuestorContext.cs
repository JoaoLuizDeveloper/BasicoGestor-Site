using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Models
{
    public class QuestorContext : IdentityDbContext
    {
        public QuestorContext(DbContextOptions<QuestorContext> options)
            : base(options)
        {
        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Anuncio> Anuncio { get; set; }
    }
}
