using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Information;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class InformationService : IInformationService
    {
        #region Constructor
        private readonly AppDbContext _context;
        public InformationService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<InformationViewModel> GetInformation()
        {
            var info = await _context.Informations.FirstOrDefaultAsync();
            if (info == null) return new InformationViewModel();

            return new InformationViewModel()
            {
                Id = info.Id,
                Address = info.Address,
                Avatar = info.Avatar,
                DateOfBirth = info.DateOfBirth,
                Email = info.Email,
                Job = info.Job,
                Name = info.Name,
                Phone = info.Phone,
                ResumeFile = info.ResumeFile,
                MapSrc = info.MapSrc
            };
        }

        public Task<Information> GetInformationModel(long id)
        {
            return _context.Informations.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<CreateOrEditInformationViewModel> FillCreateOrEditInformationViewModel()
        {
            Information information = await _context.Informations.FirstOrDefaultAsync();
            if (information == null) return new CreateOrEditInformationViewModel() { Id = 0 };

            return new CreateOrEditInformationViewModel()
            {
                Id = information.Id,
                Address = information.Address,
                Avatar = information.Avatar,
                DateOfBirth = information.DateOfBirth,
                Email = information.Email,
                Job = information.Job,
                Name = information.Name,
                Phone = information.Phone,
                ResumeFile = information.ResumeFile,
                MapSrc = information.MapSrc
            };
        }

        public async Task<bool> CreateOrEditInformation(CreateOrEditInformationViewModel information)
        {
            if (information.Id == 0)
            {
                var newInformation = new Information()
                {
                    Address = information.Address,
                    Avatar = information.Avatar,
                    DateOfBirth = information.DateOfBirth,
                    Email = information.Email,
                    Job = information.Job,
                    Name = information.Name,
                    Phone = information.Phone,
                    ResumeFile = information.ResumeFile,
                    MapSrc = information.MapSrc
                };
                await _context.Informations.AddAsync(newInformation);
                await _context.SaveChangesAsync();
                return true;
            }

            Information currentInformation = await GetInformationModel(information.Id);

            if (currentInformation == null) return false;

            currentInformation.Address = information.Address;

            if (!string.IsNullOrEmpty(information.Avatar))
                currentInformation.Avatar = information.Avatar;

            if (!string.IsNullOrEmpty(information.ResumeFile))
                currentInformation.ResumeFile = information.ResumeFile;

            currentInformation.DateOfBirth = information.DateOfBirth;
            currentInformation.Email = information.Email;
            currentInformation.Job = information.Job;
            currentInformation.Name = information.Name;
            currentInformation.Phone = information.Phone;
            currentInformation.MapSrc = information.MapSrc;

            _context.Informations.Update(currentInformation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}