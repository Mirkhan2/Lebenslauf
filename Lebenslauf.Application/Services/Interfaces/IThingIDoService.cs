using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.ThingIDo;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IThingIDoService
    {
        Task<ThingIDo> GetThingIDoById(long id);
        Task<List<ThingIDoListViewModel>> GetAllThingIDoForIndex();
        Task<bool> CreateOrEditThingIDo(CreateOrEditThingIDoViewModel thingIDo);
        Task<CreateOrEditThingIDoViewModel> FillCreateOrEditThingIDoViewModel(long id);
    }
}
