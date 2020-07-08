using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Enums
{
    public enum TipoCombustivel
    {
        [Display(Name = "Gasolina")]
        Gasolina = 1,
        [Display(Name = "Alcool")]
        Alcool = 2,
        [Display(Name = "Gas")]
        Gas = 3,
    }
}
