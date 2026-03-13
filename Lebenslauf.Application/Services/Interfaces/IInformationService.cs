using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Information;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IInformationService
    {
        Task<InformationViewModel> GetInformation();

        Task<Information> GetInformationModel(long id);

        Task<CreateOrEditInformationViewModel> FillCreateOrEditInformationViewModel();
        Task<bool> CreateOrEditInformation(CreateOrEditInformationViewModel information);
    }
}