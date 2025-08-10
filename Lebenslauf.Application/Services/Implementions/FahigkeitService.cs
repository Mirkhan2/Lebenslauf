
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Fahigkeit;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class FahigkeitService : IFahigkeitService
    {
        #region Constructor
        private readonly AppDbContext _context;
        public FahigkeitService(AppDbContext context)
        {
            _context = context;
        }

     
        #endregion
        public async Task<List<FahigkeitViewModel>> GetAllFahigkeits()
        {
            List<FahigkeitViewModel> skills = await _context.Fahigkeits
                .OrderBy(s => s.Order)
                .Select(s => new FahigkeitViewModel()
                {
                    Id = s.Id,
                    Order = s.Order,
                    Percent = s.Percent ,
                    Title = s.Title
                })
                .ToListAsync();


            return skills;
        }



    }
}
