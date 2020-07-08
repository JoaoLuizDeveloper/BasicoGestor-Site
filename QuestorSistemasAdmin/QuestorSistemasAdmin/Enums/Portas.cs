using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Enums
{
    public enum Portas
    {        
        [Display(Name = "Aguardando Aprovação")]
        Duas = 1,
        [Display(Name = "Aguardando Aprovação")]
        Tres = 2,
        [Display(Name = "Aguardando Aprovação")]
        Quatro = 3,
    }
}
