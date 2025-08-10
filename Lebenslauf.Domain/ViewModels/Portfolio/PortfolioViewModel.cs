using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.Portfolio
{
    public class PortfolioViewModel
    {
        public long Id { get; set; }


        [Display(Name = "THema")]
        public string Title { get; set; }


        [Display(Name = " DateANfangen")]
        public string Link { get; set; }


        [Display(Name = "FOto")]
        public string Image { get; set; }


        [Display(Name = "FOto Erklarung")]
        public string ImageAlt { get; set; }


        [Display(Name = "Prioritat")]
        public int Order { get; set; }


        [Display(Name = "THemen katagorie")]
        public string PortfolioCategoryName { get; set; }
    }
}
