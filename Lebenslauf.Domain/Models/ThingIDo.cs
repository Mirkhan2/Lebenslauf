using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.Models
{
    public class ThingIDo
    {
        #region Properties
        [Key]
        public long Id { get; set; }


        [Display(Name = "ICon")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]

        public string Icon { get; set; }
       

        [Display(Name = "THema")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]
        public string Title { get; set; }


        [Display(Name = "Descrption")]
        [Required(ErrorMessage = "Bitte geben Sie {0} ein")]
        [MinLength(4, ErrorMessage = "{0}Es kann nicht weniger als {1} Zeichen sein. ")]
        public string Description { get; set; }


        [Display(Name = "THema")]

        [Range(4, 12, ErrorMessage = "4 bis 12 Zeichen sein. ")]
        public int ColumnLg { get; set; } = 6;


        [Display(Name = "Bestell Prioritat")]
        public int Order { get; set; } = 0;

        #endregion


    }
}

