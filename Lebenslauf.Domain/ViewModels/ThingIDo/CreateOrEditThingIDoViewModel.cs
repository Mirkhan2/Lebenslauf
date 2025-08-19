using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.ThingIDo
{
    public class CreateOrEditThingIDoViewModel
    {

        #region Properties
        public long Id { get; set; }

        [Display(Name = "ICON")]
        [MaxLength(50, ErrorMessage = "{0}Darf nicht länger als {1} Zeichen sein. ")]
        public string Icon { get; set; }


        [Display(Name = "TItle")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(100, ErrorMessage = "{0} Darf nicht länger als {1} Zeichen sein.")]
        public string Title { get; set; }


        [Display(Name = "Bearbeitung")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein.")]
        [MaxLength(1000, ErrorMessage = "{0} Darf nicht länger als {1} Zeichen sein.")]
        public string Description { get; set; }


        [Display(Name = "Width Column item")]
        [Range(4, 12, ErrorMessage = "Der eingegebene Wert muss zwischen 4 und 12 liegen.")]
        public int ColumnLg { get; set; }


        [Display(Name = "Priotitat")]
        public int Order { get; set; }

        #endregion
    }

}
