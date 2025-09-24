
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
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

        public async Task<Erfahrung> GetErfahrungById(long id)
        {
            return await _context.Erfahrungs.FirstOrDefaultAsync(s => s.Id == id);
        }


        public async Task<CreateOrEditErfahrungViewModel> FillCreateOrEditErfahrungViewModel(long id)
        {
            if (id == 0) return new CreateOrEditErfahrungViewModel() { Id = 0 };
            
            Erfahrung erfahrung = await GetErfahrungById(id);

            if (erfahrung == null) return new CreateOrEditErfahrungViewModel() { Id = 0 };
            return new CreateOrEditErfahrungViewModel()
            {
                Description = erfahrung.Description,
                EndDate = erfahrung.EndDate,
                Id = erfahrung.Id,
                StartDate = erfahrung.StartDate,
                Title = erfahrung.Title,
                Order = erfahrung.Order
            };
        }

        public async Task<bool> CreateOrEditErfahrung(CreateOrEditErfahrungViewModel erfahrung)
        {
            if (erfahrung.Id == 0)
            {
                var newErfahrung = new Erfahrung()
                {
                    Id = erfahrung.Id,
                    StartDate = erfahrung.StartDate,
                    EndDate = erfahrung.EndDate,
                    Description = erfahrung.Description,
                    Order = erfahrung.Order,
                    Title = erfahrung.Title
                };
                await _context.Erfahrungs.AddAsync(newErfahrung);
                await _context.SaveChangesAsync();
                return true;

            }
            Erfahrung currentsErfahrung = await GetErfahrungById(erfahrung.Id);

            if (currentsErfahrung == null) return false;

            currentsErfahrung.Order = erfahrung.Order;
            currentsErfahrung.Title = erfahrung.Title;
            currentsErfahrung.StartDate = erfahrung.StartDate;
            currentsErfahrung.EndDate = erfahrung.EndDate;
            currentsErfahrung.Description = erfahrung.Description;

            _context.Erfahrungs.Update(currentsErfahrung);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteErfahrung(long id)
        {
            Erfahrung erfahrung = await GetErfahrungById(id);
            if (erfahrung == null) return false;
            _context.Erfahrungs.Remove(erfahrung);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
