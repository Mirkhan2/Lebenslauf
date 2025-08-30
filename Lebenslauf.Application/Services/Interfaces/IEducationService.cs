using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Education;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IEducationService
    {
        Task<Education> GetEducationById(long id);
        Task<List<EducationViewModel>> GetAllEducations();
        Task<CreateOrEditEducationViewModel> FillCreateOrEditEducationViewModel(long id);
        Task<bool> CreateOrEditEducation(CreateOrEditEducationViewModel education);
        Task<bool> DeleteEducation(long id);
    }
}
