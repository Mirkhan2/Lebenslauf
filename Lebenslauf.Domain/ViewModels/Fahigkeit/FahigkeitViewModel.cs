using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.Fahigkeit
{
    public class FahigkeitViewModel
    {
        public long Id { get; set; }


        [Display(Name = "themen")]
        public string Title { get; set; }


        [Display(Name = "Procent")]
        public string Percent { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; }
    }
}
