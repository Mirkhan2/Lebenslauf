using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.ThingIDo;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class ThingsIDoService : IThingIDoService
    {

        #region Constructor
        private readonly AppDbContext _context;
        public ThingsIDoService(AppDbContext context)
        {

            _context = context;
        }
        #endregion


        public async Task<List<ThingsIDoListViewModel>> GetAllThingIDoForIndex()
        {
            List<ThingsIDoListViewModel> thingIDos = await _context.ThingsIDo
                .OrderBy(t => t.Order)
                .Select(t => new ThingsIDoListViewModel()
                {
                    Id = t.Id,
                    ColumnLg = t.ColumnLg,
                    Desc = t.Desc,
                    Order = t.Order,
                    Icon = t.Icon,
                    Title = t.Title
                })
                .ToListAsync();

            return thingIDos;
        }

        
        
    }
}
