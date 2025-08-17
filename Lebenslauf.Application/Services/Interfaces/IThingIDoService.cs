using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.ThingIDo;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IThingIDoService
    {
        Task<List<ThingIDoListViewModel>> GetAllThingIDoForIndex();

    }
}
