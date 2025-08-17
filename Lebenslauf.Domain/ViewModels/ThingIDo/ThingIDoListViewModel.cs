using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.ThingIDo
{
    public class ThingIDoListViewModel
    { 
        public long Id { get; set; }
        [Display(Name = "ICon ")]
        public string Icon { get; set; }
        [Display(Name = "Titel ")]
        public string Title { get; set; }

        [Display(Name = "Beschreibung ")]
        public string Description { get; set; }

        [Display(Name = "Spaltenbreite des Elements")]
        public int ColumnLg { get; set; }
        [Display(Name = "Prioritat")]
        public int Order { get; set; }


    }
}
