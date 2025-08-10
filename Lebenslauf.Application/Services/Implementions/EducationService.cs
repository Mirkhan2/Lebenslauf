using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
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


    }
}
