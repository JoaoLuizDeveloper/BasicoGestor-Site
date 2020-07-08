using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasSite.Models
{
    public class Anuncio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }
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
        public string Portas { get; set; }

        [Column("DataVenda")]
        [Required]
        public DateTime DataVenda { get; set; }
        [Column("DataCadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }
    }
}
