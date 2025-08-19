using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.ThingIDo;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class ThingsIDoService : IThingIDoService
    {
      
        public class ThingIDoService : IThingIDoService
        {

            #region Constructor
            private readonly AppDbContext _context;

            public ThingIDoService(AppDbContext context)
            {
                _context = context;
            }
            #endregion

            public async Task<ThingIDo> GetThingIDoById(long id)
            {
                return await _context.ThingsIDo.FirstOrDefaultAsync(t => t.Id == id);
            }

            public async Task<List<ThingIDoListViewModel>> GetAllThingIDoForIndex()
            {
                List<ThingIDoListViewModel> thingIDos = await _context.ThingsIDo
                    .OrderBy(t => t.Order)
                    .Select(t => new ThingIDoListViewModel()
                    {
                        Id = t.Id,
                        ColumnLg = t.ColumnLg,
                        Description = t.Description,
                        Order = t.Order,
                        Icon = t.Icon,
                        Title = t.Title
                    })
                    .ToListAsync();

                return thingIDos;
            }

            public async Task<bool> CreateOrEditThingIDo(CreateOrEditThingIDoViewModel thingIDo)
            {

                if (thingIDo.Id == 0)
                {
                    // Create
                    var newThingIDo = new ThingIDo()
                    {
                        ColumnLg = thingIDo.ColumnLg,
                        Description = thingIDo.Description,
                        Icon = thingIDo.Icon,
                        Order = thingIDo.Order,
                        Title = thingIDo.Title
                    };

                    await _context.ThingsIDo.AddAsync(newThingIDo);
                    await _context.SaveChangesAsync();

                    return true;
                }

                // Edit
                ThingIDo currentThingIDo = await GetThingIDoById(thingIDo.Id);

                if (currentThingIDo == null) return false;

                currentThingIDo.ColumnLg = thingIDo.ColumnLg;
                currentThingIDo.Description = thingIDo.Description;
                currentThingIDo.Icon = thingIDo.Icon;
                currentThingIDo.Order = thingIDo.Order;
                currentThingIDo.Title = thingIDo.Title;

                _context.ThingsIDo.Update(currentThingIDo);
                await _context.SaveChangesAsync();

                return true;
            }

            public async Task<CreateOrEditThingIDoViewModel> FillCreateOrEditThingIDoViewModel(long id)
            {
                if (id == 0) return new CreateOrEditThingIDoViewModel() { Id = 0 };

                ThingIDo thingIDo = await GetThingIDoById(id);

                if (thingIDo == null) return new CreateOrEditThingIDoViewModel() { Id = 0 };

                return new CreateOrEditThingIDoViewModel()
                {
                    Id = thingIDo.Id,
                    ColumnLg = thingIDo.ColumnLg,
                    Description = thingIDo.Description,
                    Icon = thingIDo.Icon,
                    Order = thingIDo.Order,
                    Title = thingIDo.Title
                };
            }



        }

    }
}
