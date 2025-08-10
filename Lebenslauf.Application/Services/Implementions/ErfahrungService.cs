
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Erfahrung;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class ErfahrungService : IErfahrungService
    {
        #region COnstructor
        private readonly AppDbContext _context;
        public ErfahrungService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<List<ErfahrungViewModel>> GetAllErfahrungs()
        {
            List<ErfahrungViewModel> educations = await _context.Erfahrungs
                   .OrderBy(c => c.Order)
                   .Select(c => new ErfahrungViewModel()
                   {
                       Description = c.Description,
                       EndDate = c.EndDate,
                       Id = c.Id,
                       StartDate = c.StartDate,
                       Title = c.Title,
                       Order = c.Order
                   })
                   .ToListAsync();

            return educations;

        }
    }
}
