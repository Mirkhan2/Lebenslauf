using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Domain.ViewModels.ThingIDo
{
    public class ThingsIDoListViewModel
    {


        public long Id { get; set; }


        public string Icon { get; set; }

        public string Title { get; set; }


        public string Desc { get; set; }


        public int ColumnLg { get; set; } = 6;
        public int Order { get; set; }


    }
}
