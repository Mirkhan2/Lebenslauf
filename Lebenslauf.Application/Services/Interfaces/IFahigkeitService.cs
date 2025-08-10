using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.Fahigkeit;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IFahigkeitService
    {
        Task<List<FahigkeitViewModel>> GetAllFahigkeits();
    }
}
