using Lebenslauf.Domain.ViewModels.Erfahrung;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IErfahrungService
    {
        Task<List<ErfahrungViewModel>> GetAllErfahrungs();
    }
}
