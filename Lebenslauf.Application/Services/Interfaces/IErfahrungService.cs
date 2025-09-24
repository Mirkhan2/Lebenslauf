using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Erfahrung;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IErfahrungService
    {
        Task<Erfahrung> GetErfahrungById(long id);
        Task<List<ErfahrungViewModel>> GetAllErfahrungs();
        Task<CreateOrEditErfahrungViewModel> FillCreateOrEditErfahrungViewModel(long id);
        Task<bool> CreateOrEditErfahrung(CreateOrEditErfahrungViewModel erfahrung);
        Task<bool> DeleteErfahrung(long id);
    }
}
