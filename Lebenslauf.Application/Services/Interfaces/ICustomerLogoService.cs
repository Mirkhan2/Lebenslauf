using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.CustomerLogo;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface ICustomerLogoService
    {
        Task<List<CustomerLogoListViewModel>> GetCustomerLogoForIndexPage();
    }
}
