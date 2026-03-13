using System.Collections.Generic;
using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Fahigkeit;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IFahigkeitService
    {
        Task<List<FahigkeitViewModel>> GetAllFahigkeits();
        Task<Fahigkeit> GetFahigkeitById(long id);
        Task<CreateOrEditFahigkeitViewModel> FillCreateOrEditFahigkeitViewModel(long id);
        Task<bool> CreateOrEditFahigkeit(CreateOrEditFahigkeitViewModel skill);
        Task<bool> DeleteFahigkeit(long id);
    }
}