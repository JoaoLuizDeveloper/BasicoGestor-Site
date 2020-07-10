using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Models
{
    public class Anuncio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }

        public string Descricao { get; set; }
        public string Imagem { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string ValorCompra { get; set; }
        [Required]
        public string ValorVenda { get; set; }
        [Required]
        public string Cor { get; set; }
        [Required]
        public string Combustível { get; set; }
        [Required]
        public string FinalPlaca { get; set; }
        [Required]
        public int Portas { get; set; }
        
        [Required]
        public bool Ativo { get; set; }

        public string Slug { get; set; }
        [Column("DataVenda")]
        public DateTime DataVenda { get; set; }
    }
}
