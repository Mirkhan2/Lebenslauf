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


        [Required(ErrorMessage = "Bitte  Fuhelen sie aus")]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Bitte  Fuhelen sie aus")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Bitte  Fuhelen sie aus")]
        [MaxLength(1000)]
        public string Desc { get; set; }

        [Required(ErrorMessage = "Bitte  Fuhelen sie aus")]
        [Range(4, 12)]
        public int ColumnLg { get; set; } = 6;
        public int Order { get; set; } 

        #endregion


    }
}
