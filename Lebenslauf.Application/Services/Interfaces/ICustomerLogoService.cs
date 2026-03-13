using System.Collections.Generic;
using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.CustomerLogo;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface ICustomerLogoService
    {
        Task<List<CustomerLogoListViewModel>> GetCustomerLogoForIndexPage();
        Task<CustomerLogo> GetCustomerLogoById(long id);
        Task<CreateOrEditCustomerLogoViewModel> FillCreateOrEditCustomerLogoViewModel(long id);
        Task<bool> CreateOrEditCustomerLogo(CreateOrEditCustomerLogoViewModel logo);
        Task<bool> DeleteCustomerLogo(long id);
    }
}