using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.Information;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IInformationService
    {
        Task<InformationViewModel> GetInformation();

    }
}
