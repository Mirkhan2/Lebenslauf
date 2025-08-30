using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Education;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class EducationService : IEducationService
    {
        #region Contructor
        private readonly AppDbContext _context;
        public EducationService(AppDbContext context)
        {
            _context = context;
        }


        #endregion

        public async Task<Education> GetEducationById(long id)
        {
            return await _context.Educations.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<List<EducationViewModel>> GetAllEducations()
        {
            List<EducationViewModel> educations = await _context.Educations
                .OrderBy(c => c.Order)
                .Select(c => new EducationViewModel()
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
        public async Task<CreateOrEditEducationViewModel> FillCreateOrEditEducationViewModel(long id)
        {
            if (id == 0) return new CreateOrEditEducationViewModel() { Id = 0 };


            Education education = await GetEducationById(id);
            if (education == null) return new CreateOrEditEducationViewModel() { Id = 0 };
            return new CreateOrEditEducationViewModel()
            {
                Id = education.Id,
                Description = education.Description,
                StartDate = education.StartDate,
                EndDate= education.EndDate,
                Order = education.Order,
                Title = education.Title,

            };
            //return await _context.Educations.
        }
        public async Task<bool> CreateOrEditEducation(CreateOrEditEducationViewModel education)
        {
            if (education.Id == 0)
            {
                var newEducation = new Education()
                {
                    Description = education.Description,
                    StartDate = education.StartDate,
                    EndDate = education.EndDate,
                    Order = education.Order,
                    Title = education.Title
                };
                await _context.Educations.AddAsync(newEducation);
                await _context.SaveChangesAsync();
                return true;

            }
            Education currentEducation = await GetEducationById(education.Id);

            if (currentEducation == null ) return false;

            currentEducation.Description = education.Description;
            currentEducation.EndDate = education.EndDate;
            currentEducation.Order = education.Order;
            currentEducation.Id = education.Id;
            currentEducation.StartDate = education.StartDate;
            currentEducation.Title = education.Title;

            _context.Educations.Update(currentEducation);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteEducation(long id)
        {
            Education education = await GetEducationById(id);

            if (education == null) return false;

            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
            return true;
            
        }
    }
}
