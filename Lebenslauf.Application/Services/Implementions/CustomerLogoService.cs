using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.CustomerLogo;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class CustomerLogoService : ICustomerLogoService
    {
        #region Constructor
        private readonly AppDbContext _context;
        public CustomerLogoService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
     

        public async Task<List<CustomerLogoListViewModel>> GetCustomerLogoForIndexPage()
        {
            List<CustomerLogoListViewModel> customerLogos = await _context.CustomerLogos
                .OrderBy(c => c.Order)
                .Select(c => new CustomerLogoListViewModel()
                {
                    Id = c.Id,
                    Link = c.Link,
                    Logo = c.Logo,
                    LogoAlt = c.LogoAlt,
                    Order = c.Order,

                })
                .ToListAsync();

            return customerLogos;
        }
    }
}
