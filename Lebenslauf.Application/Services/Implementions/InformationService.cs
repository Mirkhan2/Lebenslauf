using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Information;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class InformationService : IInformationService
    {
        #region COntrcutor
        private readonly AppDbContext _context;
        public InformationService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<InformationViewModel> GetInformation()
        {
          InformationViewModel information = await _context.Informations
                .Select( i => new InformationViewModel()
                {
                    Address = i.Address,
                    Avatar = i.Avatar,
                    DateOfBirth = i.DateOfBirth,
                    Email = i.Email,
                    Name = i.Name,
                    Job = i.Job,
                    Phone = i.Phone,
                    ResumeFile = i.ResumeFile,  
                    Id = i.Id,  

                })
                .FirstOrDefaultAsync();
            if (information == null)
            {
                return new InformationViewModel();
            }
            return information;
        }
    }
}
