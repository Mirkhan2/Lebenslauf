using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                .Select(i => new InformationViewModel()
                {
                    Address = i.Address,
                    Avatar = i.Avatar,
                    DateOfBirth = i.DateOfBirth,
                    Email = i.Email,
                    Id = i.Id,
                    Job = i.Job,
                    Name = i.Name,
                    Phone = i.Phone,
                    ResumeFile = i.ResumeFile,
                    MapSrc = i.MapSrc
                })
                .FirstOrDefaultAsync();


            if (information == null)
            {
                return new InformationViewModel();
            }

            return information;
        }


        public Task<Information> GetInformationModel()
        {
            return _context.Informations.FirstOrDefaultAsync();
        }
        public async Task<CreateOrEditInformationViewModel> FillCreateOrEditInformationViewModel()
        {
            Information information = await GetInformationModel();
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

        Information currentInformation = await GetInformationModel();
            if (currentInformation == null) return false;
            currentInformation.Address = information.Address;
            currentInformation.Avatar = information.Avatar;
            currentInformation.DateOfBirth = information.DateOfBirth;
            currentInformation.Email = information.Email;
            currentInformation.Job = information.Job;
            currentInformation.Name = information.Name;
            currentInformation.Phone = information.Phone;
            currentInformation.ResumeFile = information.ResumeFile;
            currentInformation.MapSrc = information.MapSrc;
            _context.Informations.Update(currentInformation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
