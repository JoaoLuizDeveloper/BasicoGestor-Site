using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Models
{
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MarcaVeiculo { get; set; }

        public string Imagem { get; set; }

        [Column("DataCadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }

        [ForeignKey("Modelo")]
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
    }
}
