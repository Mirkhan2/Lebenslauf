using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.Portfolio
{
    public class PortfolioCategoryViewModel
    {
        public long Id { get; set; }


        [Display(Name = "THemen")]
        public string Title { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; }

    }
}
